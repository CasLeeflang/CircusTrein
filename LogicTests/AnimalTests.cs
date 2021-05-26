﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void CarnWillEatHerbTest()
        {
            // Arrange
            Animal firstAnimal = new Animal(0, "Bob", Diet.Carnivore, Size.Large);
            Animal secondAnimal = new Animal(0, "Anne", Diet.Herbivore, Size.Large);


            // Act
            bool willEat = firstAnimal.WillEat(secondAnimal);


            // Assert
            Assert.IsTrue(willEat);
        }
    }
}