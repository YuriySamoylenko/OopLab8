using System;
using System.Collections;
using System.Collections.Generic;
namespace OopLab8.Tests
{
    [TestClass]
    public class KitchenTests
    {
        [TestMethod]
        public void Furniture_Property_InitializesAsEmptyList()
        {
            // Arrange
            var kitchen = new Kitchen();

            // Act & Assert
            Assert.IsNotNull(kitchen.Furniture);
            Assert.AreEqual(0, kitchen.Furniture.Count);
        }

        [TestMethod]
        public void Area_Property_Positive()
        {
            // Arrange
            var kitchen = new Kitchen();

            // Act
            var area = kitchen.Area;

            // Assert
            Assert.IsTrue(area > 0);
        }

        [TestMethod]
        public void AddFurniture_AddsFurnitureToList()
        {
            // Arrange
            var kitchen = new Kitchen();
            var table = new Table();

            // Act
            kitchen.AddFurniture(table);

            // Assert
            Assert.AreEqual(1, kitchen.Furniture.Count);
            CollectionAssert.Contains(kitchen.Furniture.ToList(), table);
        }

        [TestMethod]
        public void RemoveFurniture_RemovesFurnitureFromList()
        {
            // Arrange
            var kitchen = new Kitchen();
            var table = new Table();
            kitchen.AddFurniture(table);

            // Act
            kitchen.RemoveFurniture(table);

            // Assert
            Assert.AreEqual(0, kitchen.Furniture.Count);
        }
    }
}
