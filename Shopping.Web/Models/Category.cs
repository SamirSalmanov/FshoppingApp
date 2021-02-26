using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Web.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required]
        public int Name { get; set; }
        public string PictureUrl { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
