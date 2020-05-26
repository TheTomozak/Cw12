using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cw12.Controllers
{
    public class PatientsController : Controller
    {

        private readonly s18969Context _context;

        public PatientsController(s18969Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Patient.ToList());
        }


        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = _context.Patient.First(pat => pat.IdPatient == id);

            if (patient == null)
            {
                return NotFound();
            }


            return View(patient);
        }
    }
}