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
        public void AddAnimalToWagon_Add2LargeHerbivores_True()
        {

            Wagon wagon = new Wagon();
            Animal animal1 = new Animal(0, "", Diet.Herbivore, Size.Large);
            Animal animal2 = new Animal(0, "", Diet.Herbivore, Size.Large);


            wagon.AddAnimalToWagon(animal1);
            wagon.AddAnimalToWagon(animal2);

            Assert.AreEqual(wagon.GetAnimals().Count(), 2);
        }

        [TestMethod()]
        public void AddAnimalToWagon_Add3LargeHerbivore_False()
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
        public void AddAnimalToWagon_AddSmallCarnLargeHerb_True()
        {
            Wagon wagon = new();
            Animal carnivore = new Animal(0, "", Diet.Carnivore, Size.Small);
            Animal herbivore = new Animal(0, "", Diet.Herbivore, Size.Large);


            wagon.AddAnimalToWagon(carnivore);



            Assert.IsTrue(wagon.AddAnimalToWagon(herbivore));
        }

        [TestMethod()]
        public void AddAnimalToWagon_AddLargeCarnSmallHerb_False()
        {
            Wagon wagon = new();
            Animal carnivore = new Animal(0, "", Diet.Carnivore, Size.Large);
            Animal herbivore = new Animal(0, "", Diet.Herbivore, Size.Small);


            wagon.AddAnimalToWagon(carnivore);


            Assert.IsFalse(wagon.AddAnimalToWagon(herbivore));
        }

        [TestMethod()]
        public void AddAnimalToWagon_Add10SmallHerb_True()
        {
            Animal Smallherb = new Animal(0, "", Diet.Herbivore, Size.Small);
            Wagon wagon = new Wagon();

            bool passed = true;

            for (int i = 0; i <= 9; i++)
            {
                if (!wagon.AddAnimalToWagon(Smallherb))
                {
                    passed = false;
                }

            }

            Assert.IsTrue(passed);
        }

        [TestMethod()]
        public void AddAnimalToWagon_Add11SmallHerb_False()
        {
            Animal Smallherb = new Animal(0, "", Diet.Herbivore, Size.Small);
            Wagon wagon = new Wagon();

            bool passed = true; 

            for (int i = 0; i <= 10 ; i++)
            {
                if (!wagon.AddAnimalToWagon(Smallherb))
                {
                    passed = false; 
                }
                
            }

            Assert.IsFalse(passed);
        }

        [TestMethod()]
        public void AddAnimalToWagon_Add3MediumHerb_True()
        {
            Animal MedHerb = new Animal(0, "", Diet.Herbivore, Size.Medium);
            Wagon wagon = new();

            bool passed = true;

            for (int i = 0; i <= 2; i++)
            {
                if (!wagon.AddAnimalToWagon(MedHerb))
                {
                    passed = false; 
                }
            }

            Assert.IsTrue(passed);
        }

        [TestMethod()]
        public void AddAnimalToWagon_Add4MediumHerb_False()
        {
            Animal MedHerb = new Animal(0, "", Diet.Herbivore, Size.Medium);
            Wagon wagon = new();

            bool passed = true;

            for (int i = 0; i <= 3; i++)
            {
                if (!wagon.AddAnimalToWagon(MedHerb))
                {
                    passed = false;
                }
            }

            Assert.IsFalse(passed);
        }

        [TestMethod()]
        public void AddWagon_CreateWagonWithAnimal_True()
        {
            WagonCollection _wagonCollection = new();

            Animal animal = new Animal(0, "", Diet.Herbivore, Size.Small);
            Wagon wagon = new();

            List<Wagon> Expected = new List<Wagon>();
            wagon.AddAnimalToWagon(animal);
            Expected.Add(wagon);



            _wagonCollection.AddWagon(animal);

            Assert.AreEqual(_wagonCollection.GetCollectionWagons().First().GetAnimals().Count(), Expected.First().GetAnimals().Count());

        }
    }
}