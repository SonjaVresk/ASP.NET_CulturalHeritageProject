using CulturalHeritageBL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CulturalHeritageWebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepo;

        public UserController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public IActionResult Index()
        {
            var blUsers = _userRepo.GetAll();

            return View(blUsers);
        }
    }
}
