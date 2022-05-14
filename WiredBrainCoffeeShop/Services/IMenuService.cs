using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiredBrainCoffeeShop.Models;

namespace WiredBrainCoffeeShop.Services
{
    public interface IMenuService
    {
        List<MenuItem> GetMenuItems();
    }
}
