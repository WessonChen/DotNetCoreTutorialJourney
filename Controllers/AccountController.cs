using DotNetCoreTutorialJourney.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreTutorialJourney.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Register(RegisterViewModel registerViewModel)
        {
            return View();
        }
    }
}
