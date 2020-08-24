using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            this.pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Pie Shop";
            var data = pieRepository.GetAllPies();
            return View(data);
        }

        public IActionResult Details(int id)
        {
            var pie = pieRepository.getPieById(id);

            return View(pie);
        }
    }
}
