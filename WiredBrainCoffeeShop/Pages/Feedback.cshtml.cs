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
    public class FeedbackModel : PageModel
    {
        [BindProperty]
        public Feedback Feedback { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                EmailService.SendFeedback(Feedback);
                return RedirectToPage("Confirmation", "Feedback");
            }
            else
            {
                return Page();
            }
        }
    }
}
