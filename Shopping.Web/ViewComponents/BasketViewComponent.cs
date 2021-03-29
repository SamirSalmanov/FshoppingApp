using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Web.ViewComponents
{
    public class BasketViewComponent:ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            var cookieCart = Request.Cookies["cartItem"];
            if (cookieCart != null && cookieCart.Length > 0)
            {
                ViewData["basketId"] = cookieCart.Split('-').Select(x => int.Parse(x)).ToList();
            }
            return View();
        }
    }
}
