using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffeeShop.Models;
using WiredBrainCoffeeShop.Services;

namespace WiredBrainCoffeeShop.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public Contact Contact { get; set; }
        public string Message { get; private set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                EmailService.SendEmail(Contact);
                return RedirectToPage("Confirmation", "Contact");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPostSubscribe(string address)
        {
            EmailService.SendEmail(address);
            return RedirectToPage("Confirmation", "Subscribe");
        }
    }
}
