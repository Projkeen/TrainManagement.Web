using System;
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
        [Display(Name = "Train lenght")]
        [Range(0,110,ErrorMessage ="Please enter a valid train length (0-110)")]
        public int TrainLength { get; set; }

        //[Required(ErrorMessage = "Please enter Average Amount Of Carriages Per Day")]
        [Display(Name = "Average Amount Of Carriages Per Day")]
        public int AverageAmountOfCarriagesPerDay { get; set; }
        

    }
}
