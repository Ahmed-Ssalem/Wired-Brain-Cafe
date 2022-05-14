using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffeeShop.Models;
using WiredBrainCoffeeShop.Services;

namespace WiredBrainCoffeeShop.Pages
{
    public class MenuModel : PageModel
    {
        public List<MenuItem> Menu { get; set; }

        public void OnGet()
        {
            var menuService = new MenuService();

            Menu = menuService.GetMenuItems();
        }
    }
}
