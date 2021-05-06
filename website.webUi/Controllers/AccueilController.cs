using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using website.webUi.Models;

namespace website.webUi.Controllers
{
    public class AccueilController : Controller
    {
        public IActionResult Index()
        {
             var ViewModel = new TestViewModel();
            ViewModel.Message = "c'est le feu je l'espere";
            
            return View(ViewModel);
        }

        public IActionResult LaView()
        {
            var ViewModel = new TestViewModel();
            ViewModel.Message = "jte jure comment je suis fort";

            return View(ViewModel);
        }

        public IActionResult Lalist()
        {
            var ViewModel = new TestViewModel();
            var listName =  ViewModel.NameArray;
      

            return View(listName);
        }
    }
}
