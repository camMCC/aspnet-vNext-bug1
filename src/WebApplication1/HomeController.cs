using Microsoft.AspNet.Mvc;
using System;

namespace WebApplication1
{

    public class HomeController : Controller
    {

        public IActionResult Index() {
            return View();
        }

    }

}
