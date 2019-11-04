using Microsoft.AspNetCore.Identity;

namespace DotNetCoreTutorialJourney.Models
{
    public class AppUser : IdentityUser
    {
        public string Gender { get; set; }
    }
}
