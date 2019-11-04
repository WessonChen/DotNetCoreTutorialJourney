using DotNetCoreTutorialJourney.Models;
using DotNetCoreTutorialJourney.Utilities;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreTutorialJourney.ViewModels
{
    public class EmployeeCreateViewModel
    {
        public int Id { get; set; }

        [Required, MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }

        [Display(Name = "Office Email")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
            ErrorMessage = "Invalid email format")]
        [Required]
        public string Email { get; set; }

        [Required]
        public Dept? Department { get; set; }
        public IFormFile Photo { get; set; }
        [AGreaterThanBC("B", "C", ErrorMessage = "It should be b+c")]
        public int? A { get; set; }
        public int? B { get; set; }
        public int? C { get; set; }
    }
}