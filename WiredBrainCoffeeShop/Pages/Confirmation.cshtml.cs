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
    public class ConfirmationModel : PageModel
    {
        public string Message { get; set; }

        public void OnGetContact()
        {
            Message = "Your email was sent successfully!";
        }


        public void OnGetSubscribe()
        {
            Message = "You have been added to our mailing list.";
        }

        public void OnGetFeedback()
        {
            Message = "Your feedback was sent successfully!";
        }
    }
}
