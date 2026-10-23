using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Ngay1.Controllers
{
    public class HelloController : Controller
    {
       public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult WelcomeView(string name, int numTimes = 1)
        {
            ViewData["Message"] ="Hello" +name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

    }
}
