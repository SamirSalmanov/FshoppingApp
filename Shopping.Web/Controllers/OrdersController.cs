﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shopping.Web.Data;
using Shopping.Web.Models;
using Shopping.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Web.Controllers
{
    public class OrdersController : Controller
    {
        public readonly ShoppingContext _context;
        private readonly UserManager<SUser> _userManager;


        public OrdersController(ShoppingContext context, UserManager<SUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        //public IActionResult AddToCart()
        //{
        //    var cookieCart = Request.Cookies["cartItem"];
        //    if(cookieCart != null && cookieCart.Length>0)
        //    {
        //        List<int> productIds = cookieCart.Split('-').Select(x => int.Parse(x)).ToList();
        //        List<Product> products = _context.Products.Include("ProductPictures.Picture") .Where(x => productIds.Contains(x.ID)).ToList();
        //        return PartialView("BasketProduct",products);
        //    }
        //    return PartialView("BasketProduct");
        //}

        [Authorize]
        [Route("checkout")]
        public IActionResult Checkout()
        {
            var cookieCart = Request.Cookies["cartItem"];
            if (cookieCart != null && cookieCart.Length > 0)
            {
                List<int> productIds = cookieCart.Split('-').Select(x => int.Parse(x)).ToList();
                List<Product> products = _context.Products.Where(x => productIds.Contains(x.ID)).ToList();
                CheckoutVM vm = new CheckoutVM()
                {
                    Products = products,
                    ProductIds = productIds,
                    SUsers = _userManager.GetUserAsync(User)
                };
                return View(vm);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> PlacedProduct(string Address, string PhoneNumber)
        {

            if (User.Identity.IsAuthenticated)
            {
                var cookieCart = Request.Cookies["cartItem"];
                if (cookieCart != null && cookieCart.Length > 0)
                {
                    List<int> productIds = cookieCart.Split('-').Select(x => int.Parse(x)).ToList();
                    List<Product> products = _context.Products.Where(x => productIds.Contains(x.ID)).ToList();
                    Task<SUser> currentUser = _userManager.GetUserAsync(User);
                    Order newOrder = new Order();
                    newOrder.CustomerID = currentUser.Result.Id;
                    newOrder.CustomerEmail = currentUser.Result.Email;
                    newOrder.CustomerPhone = PhoneNumber;
                    newOrder.CustomerName = currentUser.Result.Firstname + " " + currentUser.Result.Lastname;
                    newOrder.CustomerAddress = Address;
                    newOrder.PaymentMethod = 1;
                    newOrder.OrderItems = new List<OrderItem>();
                    foreach (var product in products)
                    {
                        var orderItem = new OrderItem()
                        {
                            ProductID = product.ID,
                            ProductName = product.Name,
                            ItemPrice = product.Price,
                            Quantity = productIds.Where(x => product.ID == x).Count()
                        };
                        newOrder.OrderItems.Add(orderItem);
                        newOrder.OrderCode = Guid.NewGuid().ToString();
                        newOrder.TotalAmmount = newOrder.OrderItems.Sum(x => (x.ItemPrice * x.Quantity));

                        product.Count-=newOrder.OrderItems.First(x=>x.ProductID==product.ID).Quantity;

                        newOrder.OrderHistory=new List<OrderHistory>()
                        {

                            new OrderHistory()
                            {
                                OrderStatus = (int)OrderStatus.Placed,
                                ModifiedOn = DateTime.Now,
                                Note = "Sifaris qeyde alindi."

                            }
                        };
                        newOrder.PlacedOn = DateTime.Now;
                    }
                    _context.Add(newOrder);
                    await _context.SaveChangesAsync();
                    Response.Cookies.Delete("cartItem");
                }

            }
            return Json(null);

        }
    }
}
