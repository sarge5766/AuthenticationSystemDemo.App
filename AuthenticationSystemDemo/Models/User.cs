using System.ComponentModel.DataAnnotations;

namespace AuthenticationSystemDemo.Models {
    public class User {
        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Invalid Email address!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [StringLength(12, ErrorMessage = "Between 8 and 12 characters required!", MinimumLength = 8)]
        public string  Password { get; set; }
    }
}