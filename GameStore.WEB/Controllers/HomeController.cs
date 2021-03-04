using GameStore.WEB.Models;
using GameStore.WEB.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("/Home/HandleError")]
        public ActionResult<ErrorDetails> HandleError()
        {
            return View("Error", Error._404);
        }
    }
}
