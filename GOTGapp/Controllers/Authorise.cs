using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace gotgApp.Controllers
{
    public class Authorise : Controller
    {
        public IActionResult Index()
        {
            return View();
            
        }

        [Authorize]
        public class IncidentReportsController : Controller;
        public class DonationController : Controller;
        public class VolenteerController : Controller;
    }
}
