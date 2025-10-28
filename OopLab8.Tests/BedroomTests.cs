namespace OopLab8.Tests
{
    [TestClass]
    public class BedroomTests
    {
        [TestMethod]
        public void Furniture_Property_InitializesAsEmptyList()
        {
            // Arrange
            var bedroom = new Bedroom();

            // Act & Assert
            Assert.IsNotNull(bedroom.Furniture);
            Assert.AreEqual(0, bedroom.Furniture.Count);
        }

        [TestMethod]
        public void Area_Property_Positive()
        {
            // Arrange
            var bedroom = new Bedroom();

            // Act
            var area = bedroom.Area;

            // Assert
            Assert.IsTrue(area > 0);
        }

        [TestMethod]
        public void AddFurniture_AddsFurnitureToList()
        {
            // Arrange
            var bedroom = new Bedroom();
            var bed = new Bed();

            // Act
            bedroom.AddFurniture(bed);

            // Assert
            Assert.AreEqual(1, bedroom.Furniture.Count);
            CollectionAssert.Contains(bedroom.Furniture.ToList(), bed);
        }

        [TestMethod]
        public void RemoveFurniture_RemovesFurnitureFromList()
        {
            // Arrange
            var bedroom = new Bedroom();
            var bed = new Bed();
            bedroom.AddFurniture(bed);

            // Act
            bedroom.RemoveFurniture(bed);

            // Assert
            Assert.AreEqual(0, bedroom.Furniture.Count);
        }
    }
}
