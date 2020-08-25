using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnDotNetCore.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentsRepositoy comments;

        public CommentController(ICommentsRepositoy comments)
        {
            this.comments = comments;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Comments comment)
        {
            comments.AddComment(comment);
            return RedirectToAction("Success");
        }
        public IActionResult Success()
        {
            return View();
        }
    }
}
