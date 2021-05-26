using Microsoft.VisualStudio.TestTools.UnitTesting;
using Variables;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Tests
{
    [TestClass()]
    public class WagonTests
    {
        [TestMethod()]
        public void Add2LargeAnimalsToWagonTest()
        {

            Wagon wagon = new Wagon();
            Animal animal1 = new Animal(0, "", Diet.Herbivore, Size.Large);
            Animal animal2 = new Animal(0, "", Diet.Herbivore, Size.Large);


            wagon.AddAnimalToWagon(animal1);
            wagon.AddAnimalToWagon(animal2);

            Assert.AreEqual(wagon.GetAnimals().Count(), 2);
        }

        [TestMethod()]
        public void Add3LargeAnimalsToWagonTest()
        {
            Wagon wagon = new Wagon();

            bool passed = true;

            for (int i = 0; i <= 2; i++)
            {
                if (!wagon.AddAnimalToWagon(new Animal(0, "", Diet.Herbivore, Size.Large)))
                {
                    passed = false;
                };
            }

            Assert.IsFalse(passed);
        }

        [TestMethod()]
        public void AddSmallCarnLargeHerbAnimalToWagon()
        {
            Wagon wagon = new();
            Animal carnivore = new Animal(0, "", Diet.Carnivore, Size.Small);
            Animal herbivore = new Animal(0, "", Diet.Herbivore, Size.Large);


            wagon.AddAnimalToWagon(carnivore);



            Assert.IsTrue(wagon.AddAnimalToWagon(herbivore));
        }

        [TestMethod()]
        public void AddlargeCarnSmallHerbAnimalToWagon()
        {
            Wagon wagon = new();
            Animal carnivore = new Animal(0, "", Diet.Carnivore, Size.Large);
            Animal herbivore = new Animal(0, "", Diet.Herbivore, Size.Small);


            wagon.AddAnimalToWagon(carnivore);


            Assert.IsFalse(wagon.AddAnimalToWagon(herbivore));
        }        
    }
}