using System.ComponentModel.DataAnnotations;

namespace LoginSystem.ViewModels {
    public class ChangePasswordViewModel {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be at least {2} and max {1} characters")]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        [Compare("ConfirmNewPassword", ErrorMessage = "Passwords doo not match")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Confirm password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        public string ConfirmNewPassword { get; set; }
    }
}
