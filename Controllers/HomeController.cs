using Identity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Identity.Controllers
{
    public class HomeController : Controller
    {
        private UserManager<IdentityUser> userManager;

     

        public HomeController(UserManager<IdentityUser> userMgr)
        {
            userManager = userMgr;
        }


       
        public IActionResult Index()
        {
            return View();
        }
        
    }
}