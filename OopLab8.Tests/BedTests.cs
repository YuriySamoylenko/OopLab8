﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab8.Tests
{
    [TestClass]
    public class BedTests
    {
        [TestMethod]
        public void NumberOfLegs_Property_ReturnsValidValue()
        {
            // Arrange
            var bed = new Bed();

            // Act
            var place = bed.Place;

            // Assert
            Assert.AreEqual(4, bed.NumberOfLegs);
        }

        [TestMethod]
        public void Move_UpdatesPlace()
        {
            // Arrange
            var bed = new Bed();
            var newPlace = Place.South;

            // Act
            bed.Move(newPlace);

            // Assert
            Assert.AreEqual(newPlace, bed.Place);
        }
    }
}
