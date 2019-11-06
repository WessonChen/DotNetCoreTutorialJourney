using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreTutorialJourney.ViewModels
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Claims = new List<string>();
            Roles = new List<string>();
        }

        public string Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Gender { get; set; }

        public IList<string> Claims { get; set; }

        public IList<string> Roles { get; set; }
    }
}
