using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IdeaManager_FE.Models;

namespace IdeaManager_FE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult IdeaCreator()
        {
            ViewData["Message"] = "A message";

            return View();
        }

		public IActionResult IdeaDeployer()
		{
			ViewData["Message"] = "A message";

			return View();
		}
	}
}
