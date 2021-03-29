using Shopping.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Web.ViewModels
{
    public class ProductFilterVM
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public int? ProductCount { get; set; }
        public int? SortBy { get; set; }
        public int? CategoryID { get; set; }
        public int MaxProductPrice { get; set; }
        public int MaxPrice { get; set; }
        public int MinPrice { get; set; }
        public int CurrentPage { get; set; }
        public int EndPage { get; set; }



    }
}
