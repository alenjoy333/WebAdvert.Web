using System.ComponentModel.DataAnnotations;

namespace WebAdvert.Web.Models
{
    public class ConfirmModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "Email is required")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Code is required")]

        public string Code { get; set; }
    }
}
