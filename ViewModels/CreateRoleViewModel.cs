using System.ComponentModel.DataAnnotations;

namespace DotNetCoreTutorialJourney.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
