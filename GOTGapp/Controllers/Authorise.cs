using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace gotgApp.Controllers
{
    [Authorize]
    public class AuthoriseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
