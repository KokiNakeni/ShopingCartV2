using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models.ViewModels
{
    public class CreateViewModel
    {

        [Required, MinLength(2, ErrorMessage = "Minimum length is 2")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        public string SurnameName { get; set; }

        [DataType(DataType.Password), Required, MinLength(4, ErrorMessage = "Minimum length is 4")]
        public string Password { get; set; }

        [DataType(DataType.EmailAddress)] // Add this attribute to specify that it's an email address
        [Required(ErrorMessage = "Email is required")] // Add required validation
        [EmailAddress(ErrorMessage = "Invalid Email Address")] // Add email format validation
        public string Email { get; set; } // Add the Email property

        // Include other properties here that you want to capture in the database
        [Required(ErrorMessage = "Street Address is required.")]
        public string StreetAddress { get; set; }

        [MaxLength(100)]
        public string Suburb { get; set; }

        [MaxLength(100)]
        public string Town { get; set; }

        [Required(ErrorMessage = "Postal Code is required.")]
        [MaxLength(100)]
        public string PostalCode { get; set; }
    }
}
    

