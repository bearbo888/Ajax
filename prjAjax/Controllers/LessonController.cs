using Microsoft.AspNetCore.Mvc;
using prjAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjAjax.Controllers
{
    public class LessonController : Controller
    {
        public IActionResult Index(User user)
        {
            //System.Threading.Thread.Sleep(5000);

            if (String.IsNullOrEmpty(user.name))
                user.name = "Ajax";

            return Content($"HI {user.name}, your age is {user.age}, email is {user.email}", "text/plain", System.Text.Encoding.UTF8);
        }

        public IActionResult Ajax()
        {
            return View();
        }

        public IActionResult AjaxPost()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
