using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models
{
    public class User
    {
        public string Id { get; set; }

        [Required, MinLength(2, ErrorMessage = "Minimum length is 2")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        public string Surname { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password), Required, MinLength(4, ErrorMessage = "Minimum length is 4")]
        public string Password { get; set; }
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