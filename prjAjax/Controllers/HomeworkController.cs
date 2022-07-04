using Microsoft.AspNetCore.Mvc;
using prjAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjAjax.Controllers
{
    public class HomeworkController : Controller
    {
        private readonly demoContext _context;

        public HomeworkController(demoContext conetxt)
        {
            _context = conetxt;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HW01()
        {
            return View();
        }

        public IActionResult HW02()
        {
            var member = from q in _context.Members select q.Name;

            return View();
        }

        public bool hasExist(string name)
        {
            var member = from q in _context.Members where q.Name.Equals(name) select q.Name;

            if (member.Count() > 0)
                return true;
            return false;
        }
    }
}
