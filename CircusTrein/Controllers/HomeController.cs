using CircusTrein.Models;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;
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
            var newAnimal = new Animal(AnimalManager.GetNewId(), animal.Name, animal.Diet, animal.Size); //Map viewmodel to Model

            if (AnimalManager.ValidateModel(newAnimal)) //if the model is valid -> add to the animal list

            {
                Storage.AnimalStorage.AddAnimalToList(newAnimal);
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
            Logic.Sorting.CheckForConstraints(Logic.AnimalManager.GetAnimals().OrderByDescending(o => o.Size).ToList());
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
