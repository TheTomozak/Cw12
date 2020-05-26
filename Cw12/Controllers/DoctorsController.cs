using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Cw12.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cw12.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly s18969Context _context;

        public DoctorsController(s18969Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.Doctor.ToList());
        }

        public IActionResult GetDoctors()
        {
            return View();
        }
    }
}