using System.ComponentModel.DataAnnotations;
namespace TrainManagement.Web.Models
{
    public class TrainModel
    {
        [Key]
        public int TrainId { get; set; }

        [Required(ErrorMessage = "Please enter departure station")]
        [Display(Name = "Start from")]
        public string? DepartureStation { get; set; }

        [Required(ErrorMessage = "Please enter final destination")]
        [Display(Name = "Final destination")]
        public string? FinalDestination { get; set; }

        //[Required(ErrorMessage = "Please enter train length")]
        [Display(Name = "Train lenght for this direction")]
        [Range(1, 100, ErrorMessage = "Please enter a valid train length (1-100)")]
        public int TrainLength { get; set; }

        [Display(Name = "Including empty carriages")]
        [Range(0, 100, ErrorMessage = "Please enter a valid amount of empty carriages (1-100)")]
        public int EC { get; set; }

        [Display(Name = "Maximum train weight for this direction")]
        public int Weight { get; set; }

        //[Required(ErrorMessage = "Please enter Average Amount Of Carriages Per Day")]
        [Display(Name = "Average amount of carriages per day")]
        public int AverageAmountPerDay { get; set; } 

        [Display(Name = "Amount of carriages with dangerous cargo")]
        public int DC { get; set; } 

    }
}
