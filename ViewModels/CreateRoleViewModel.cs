using System.ComponentModel.DataAnnotations;

namespace DotNetCoreTutorialJourney.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
