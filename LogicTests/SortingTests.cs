using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Variables;

namespace Logic.Tests
{
    [TestClass()]
    public class SortingTests
    {

        Sorting _sorting = new();

        [TestMethod()]
        public void Sort_5H1_3H3_1H5_Expect_2Wagons()
        {
            //  Arrange
            List<Animal> animals = new List<Animal>();

            // H1 = Small Herbivore, H5 = Large Herbivore, C5 = Large Carnivore...etc
            Animal H1 = new Animal(0, "", Diet.Herbivore, Size.Small);
            Animal H3 = new Animal(0, "", Diet.Herbivore, Size.Medium);
            Animal H5 = new Animal(0, "", Diet.Herbivore, Size.Large);

            for (int i = 0; i < 5; i++)
            {
                animals.Add(H1);
            }
            for (int i = 0; i < 3; i++)
            {
                animals.Add(H3);
            }
            animals.Add(H5);

            //  Act
            IEnumerable<Wagon> train = _sorting.Sort(animals);

            //  Assert
            Assert.AreEqual(2, train.Count());
        }

        [TestMethod()]
        public void Sort_3H5_1C1_3C3_2C5_Expected_6Wagons()
        {
            //  Arrange
            List<Animal> animals = new List<Animal>();
            Animal H5 = new Animal("", Diet.Herbivore, Size.Large);
            Animal C1 = new Animal("", Diet.Carnivore, Size.Small);
            Animal C3 = new Animal("", Diet.Carnivore, Size.Medium);
            Animal C5 = new Animal("", Diet.Carnivore, Size.Large);

            for (int i = 0; i < 3; i++)
            {
                animals.Add(H5);
            }
            for (int i = 0; i < 3; i++)
            {
                animals.Add(C3);
            }
            for (int i = 0; i < 2; i++)
            {
                animals.Add(C5);
            }
            animals.Add(C1);

            //  Act
            IEnumerable<Wagon> train = _sorting.Sort(animals);

            //  Assert
            Assert.AreEqual(6, train.Count());

        }

        [TestMethod()]
        public void Sort_5H1_5H3_5H5_2C1_2C3_2C5_Expected_8Wagons()
        {
            //  Arrange
            List<Animal> animals = new List<Animal>();
            Animal H1 = new Animal(0, "", Diet.Herbivore, Size.Small);
            Animal H3 = new Animal(0, "", Diet.Herbivore, Size.Medium);
            Animal H5 = new Animal(0, "", Diet.Herbivore, Size.Large);
            Animal C1 = new Animal("", Diet.Carnivore, Size.Small);
            Animal C3 = new Animal("", Diet.Carnivore, Size.Medium);
            Animal C5 = new Animal("", Diet.Carnivore, Size.Large);

            for (int i = 0; i < 5; i++)
            {
                animals.Add(H1);
            }
            for (int i = 0; i < 5; i++)
            {
                animals.Add(H3);
            }
            for (int i = 0; i < 5; i++)
            {
                animals.Add(H5);
            }
            for (int i = 0; i < 2; i++)
            {
                animals.Add(C1);
            }
            for (int i = 0; i < 2; i++)
            {
                animals.Add(C3);
            }
            for (int i = 0; i < 2; i++)
            {
                animals.Add(C5);
            }

            //  Act
            IEnumerable<Wagon> train = _sorting.Sort(animals);

            // Assert
            Assert.AreEqual(8, train.Count());
        }

        [TestMethod()]
        public void Sort_1H1_3H3_2H5_Expected_2Wagons()
        {
            //  Arrange
            List<Animal> animals = new List<Animal>();
            Animal H1 = new Animal(0, "", Diet.Herbivore, Size.Small);
            Animal H3 = new Animal(0, "", Diet.Herbivore, Size.Medium);
            Animal H5 = new Animal(0, "", Diet.Herbivore, Size.Large);

            for (int i = 0; i < 1; i++)
            {
                animals.Add(H1);
            }
            for (int i = 0; i < 3; i++)
            {
                animals.Add(H3);
            }
            for (int i = 0; i < 2; i++)
            {
                animals.Add(H5);
            }

            //  Act
            IEnumerable<Wagon> train = _sorting.Sort(animals);

            // Assert
            Assert.AreEqual(2, train.Count());
        }

        [TestMethod()]
        public void Sort_3H3_2H5_1C1_Expected_2Wagons()
        {
            //  Arrange
            List<Animal> animals = new List<Animal>();
            Animal C1 = new Animal(0, "", Diet.Carnivore, Size.Small);
            Animal H3 = new Animal(0, "", Diet.Herbivore, Size.Medium);
            Animal H5 = new Animal(0, "", Diet.Herbivore, Size.Large);

            for (int i = 0; i < 3; i++)
            {
                animals.Add(H3);
            }
            for (int i = 0; i < 2; i++)
            {
                animals.Add(H5);
            }
            for (int i = 0; i < 1; i++)
            {
                animals.Add(C1);
            }

            //  Act
            IEnumerable<Wagon> train = _sorting.Sort(animals);

            //  Assert
            Assert.AreEqual(2, train.Count());
        }
    }
}