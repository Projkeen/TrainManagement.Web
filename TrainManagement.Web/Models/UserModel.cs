using System.ComponentModel.DataAnnotations;

namespace TrainManagement.Web.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter your First name")]
        [MinLength(3, ErrorMessage = "First name is too short")]
        [Display(Name = "First name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your Last name")]
        [MinLength(3, ErrorMessage = "Last name is too short")]
        [Display(Name = "Last name")]
        public string? LastName { get; set; }
        public string? Password { get; set; }
    }
}
