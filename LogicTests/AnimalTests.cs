using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;
using Variables;

namespace Logic.Tests
{
    [TestClass()]
    public class AnimalTests
    {
        [TestMethod()]
        public void WillEat_LargeCarnEatsLargeHerb_True()
        {
            // Arrange
            Animal lCarn = new Animal(0, "Bob", Diet.Carnivore, Size.Large);
            Animal lHerb = new Animal(0, "Anne", Diet.Herbivore, Size.Large);


            // Act
            bool willEat = lCarn.WillEat(lHerb);


            // Assert
            Assert.IsTrue(willEat);
        }

        [TestMethod()]
        public void WillEat_SmallCarnLargeHerb_False()
        {
            Animal sCarn = new Animal(0, "", Diet.Carnivore, Size.Small);
            Animal lHerb = new Animal(0, "", Diet.Herbivore, Size.Large);

            Assert.IsFalse(sCarn.WillEat(lHerb));
        }

        [TestMethod()]
        public void WilLEat_MediumCarnMediumHerb_True()
        {
            Animal MC = new Animal(0, "", Diet.Carnivore, Size.Medium);
            Animal MH = new Animal(0, "", Diet.Herbivore, Size.Medium);

            Assert.IsTrue(MC.WillEat(MH));
        }

        [TestMethod()]
        public void MCWillEatMC()
        {
            Animal MC1 = new Animal(0, "", Diet.Carnivore, Size.Medium);
            Animal MC2 = new Animal(0, "", Diet.Carnivore, Size.Medium);

            Assert.IsTrue(MC1.WillEat(MC2));
        }

        [TestMethod()]
        public void LCWillEatSH()
        {
            Animal LC = new Animal(0, "", Diet.Carnivore, Size.Large);
            Animal SH = new Animal(0, "", Diet.Herbivore, Size.Small);

            Assert.IsTrue(LC.WillEat(SH));
        }


    }
}