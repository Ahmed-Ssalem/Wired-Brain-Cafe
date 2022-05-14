using System.ComponentModel.DataAnnotations;


namespace WiredBrainCoffeeShop.Models
{
    public class Info
    {

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid Name!")]
        public string Name { get; set; }


        [Phone(ErrorMessage = "Invalid phone number!")]
        [Required]
        public string Phone { get; set; }


        [EmailAddress(ErrorMessage = "Invalid email address!")]
        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 3, ErrorMessage = "Invalid message!")]
        public string Message { get; set; }
    }
}
