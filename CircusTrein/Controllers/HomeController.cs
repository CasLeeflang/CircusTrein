using CircusTrein.Models;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace CircusTrein.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult NewTrain()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnimalToList(AnimalView animal)
        {
            AnimalManager.SetId(animal);
            if (AnimalManager.ValidateModel(animal))
            {
                Storage.AnimalStorage.AddAnimalToList(animal);
            }
            else { Console.WriteLine("Something went wrong while adding the Animal, Please try again!"); }

            
            return RedirectToAction("NewTrain");
        }

        public IActionResult RemoveAnimalFromList(int animalId)
        {
            Storage.AnimalStorage.RemoveAnimalFromList(animalId);
            return RedirectToAction("NewTrain");
        }


        public IActionResult GenerateTrain()
        {
            Logic.WagonManager.ClearWagons();
            Logic.Sorting.CheckForConstraints(Storage.AnimalStorage.GetAnimalList());
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
