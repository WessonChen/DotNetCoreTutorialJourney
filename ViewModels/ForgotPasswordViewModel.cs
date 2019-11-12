using System.ComponentModel.DataAnnotations;

namespace DotNetCoreTutorialJourney.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
