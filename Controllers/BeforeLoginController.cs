using Microsoft.AspNetCore.Mvc;

namespace Medkart.com__An_online_medical_store_.Controllers
{
    public class BeforeLoginController : Controller
    {
        public IActionResult UserRegistration()
        {
            return View();
        }
    }
}
