using CircusTrein.Models;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Storage;
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

        AnimalCollection _animalCollection = new();
        WagonCollection _wagonCollection = new();
        Sorting _sorting = new();
       
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
            var newAnimal = new Animal(_animalCollection.GetMaxAnimalId() + 1, animal.Name, animal.Diet, animal.Size); //Map viewmodel to Model

            if (_animalCollection.ValidateModel(newAnimal)) //if the model is valid -> add to the animal list

            {
                _animalCollection.AddAnimal(newAnimal);
            }

            else { Console.WriteLine("Something went wrong while adding the Animal, Please try again!"); }


            return RedirectToAction("NewTrain");
        }

        public IActionResult RemoveAnimalFromList(int animalId)
        {
            _animalCollection.DeleteAnimal(animalId);
            return RedirectToAction("NewTrain");
        }

        public IActionResult GenerateTrain()
        {
            _sorting.Sort(_animalCollection.GetAnimals().OrderByDescending(o => o.Diet).ThenByDescending(o => o.Size));

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
