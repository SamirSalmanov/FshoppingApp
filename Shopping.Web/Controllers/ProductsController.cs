using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopping.Web.Data;
using Shopping.Web.Models;
using Shopping.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Web.Controllers
{
    public class ProductsController : Controller
    {
        private ShoppingContext _context;

        public ProductsController(ShoppingContext context)
        {
            _context = context;
        }
        [Route("mehsullar")]

        public IActionResult Index(int? categoryId, string searchTerm, int? minPrice, int? maxPrice, int? sortBy, int? pageNo)
        {
            pageNo ??= 1;
            minPrice ??= 0;
            maxPrice ??= (int)_context.Products.Max(x => x.Price);

            ProductFilterVM vm = new()
            {
                Products = SearchProducts(categoryId, searchTerm, minPrice, maxPrice, sortBy, pageNo.Value, out int count),
                Categories = _context.Categories.Include(x => x.Products).ToList(),
                ProductCount = SearchProductCount(),
                SortBy = sortBy,
                CategoryID=categoryId,
                CurrentPage=pageNo.Value,
                MaxProductPrice=(int)_context.Products.Max(x=>x.Price),
                MinPrice=minPrice.Value,
                MaxPrice=maxPrice.Value
            };

            vm.EndPage = (int)Math.Ceiling((decimal)count / 3);

            return View(vm);
        }
        public int SearchProductCount()
        {
            return _context.Products.Count();
        }
        public List<Product> SearchProducts(int? categoryId,string searchTerm,int? minPrice,int? maxPrice,int? sortBy,int pageNo, out int count)
        {
            var productList = _context.Products.AsQueryable();
            if (categoryId.HasValue)
            {
                productList = productList.Where(p => p.CategoryID == categoryId);
            }
            if(minPrice.HasValue && maxPrice.HasValue && minPrice <= maxPrice)
            {
                productList = productList.Where(p => p.Price >= minPrice && p.Price <= maxPrice);
            }
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                productList = productList.Where(x => x.Name.Contains(searchTerm));  
            }
            if (sortBy.HasValue)
            {
                switch (sortBy)
                {
                    case 1:
                        productList = productList.OrderBy(x => x.ID);
                        break;

                    case 3:
                        productList = productList.OrderBy(x => x.Price);
                        break;
                    case 4:
                        productList = productList.OrderByDescending(x => x.Price);
                        break;

                    default:
                        productList = productList.OrderByDescending(x => x.ID);

                        break;

                }
            }

            int skipCount = (pageNo - 1) * 3;
            count = productList.Count();

            return productList.Include("ProductPictures.Picture").Skip(skipCount).Take(3).ToList();
        }
        [HttpPost]
        public IActionResult FindProductByID(int? productId)
        {
            var productList = _context.Products.Include("ProductPictures.Picture")
                .FirstOrDefault(x => x.ID == productId);
            HomeVM vm = new HomeVM()
            {
                Product = productList
            };
            return PartialView("ProductQuickView", vm);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Product singlePro = _context.Products.Include("ProductPictures.Picture").FirstOrDefault(p => p.ID == id);
            if (singlePro == null) return NotFound();
            ProductDetailVM vm = new ProductDetailVM();
            vm.Product = singlePro;

            vm.FeaturedProducts = _context.Products.Include("ProductPictures.Picture")
                .Where(x => x.IsFeatured).ToList();

            vm.SameCategoryPro = await _context.Products.Include("ProductPictures.Picture")
                .Where(x => x.CategoryID == singlePro.CategoryID && x.ID!= singlePro.ID)
                .Take(3)
                .ToListAsync();
            return View(vm);
        }
    }
}
