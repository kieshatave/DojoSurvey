using System;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Form()
        {
            return View();
        }

        [HttpGet("return")]
        public ViewResult Return()
        {
            return View("return");
        }

        [HttpPost("return")]
        public ViewResult ReturnedPost(string Name, string Location, string Language, string Message)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Message = Message;
            return View("return");
        }
    }
}