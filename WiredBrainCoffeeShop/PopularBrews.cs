using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiredBrainCoffeeShop.Services;

namespace WiredBrainCoffeeShop
{
    public class PopularBrews : ViewComponent
    {
        public IViewComponentResult Invoke(int count)
        {
            var menu = new MenuService();
            return View(menu.GetPopularItems().Take(count));
        }
    }
}
