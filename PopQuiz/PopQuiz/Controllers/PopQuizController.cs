using System;
using Microsoft.AspNetCore.Mvc;

namespace PopQuiz.Controllers
                                 
{
    public class PopQuizController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}