using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cw12.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        // public string Welcome(string name, int numTimes = 1)
        // {
        //     return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //     //Program HtmlEncoder.Default.Encode używa programu do ochrony aplikacji przed złośliwymi danymi wejściowymi (tj. JavaScript).
        //     //Używa funkcji opcjonalnego parametru języka C#, aby wskazać, numTimes że parametr domyślnie przyjmuje wartość 1, jeśli dla tego parametru nie jest przenoszona żadna wartooć.
        // }


        // public string Welcome(string name, int ID = 1)
        // {
        //     return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        // }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }


    }
}