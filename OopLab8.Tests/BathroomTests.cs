namespace OopLab8.Tests
{
    [TestClass]
    public class BathroomTests
    {
        [TestMethod]
        public void Furniture_Property_InitializesAsEmptyList()
        {
            // Arrange
            var bathroom = new Bathroom();

            // Act & Assert
            Assert.IsNotNull(((IRoom)bathroom).Furniture);
            Assert.AreEqual(0, ((IRoom)bathroom).Furniture.Count);
        }

        [TestMethod]
        public void Area_Property_Positive()
        {
            // Arrange
            var bathroom = new Bathroom();

            // Act
            var area = bathroom.Area;

            // Assert
            Assert.IsTrue(area > 0);
        }

        [TestMethod]
        public void AddFurniture_AddsFurnitureToList()
        {
            // Arrange
            var bathroom = new Bathroom();
            var chair = new Chair();

            // Act
            bathroom.AddFurniture(chair);

            // Assert
            Assert.AreEqual(1, bathroom.Furniture.Count);
            CollectionAssert.Contains(bathroom.Furniture.ToList(), chair);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddInvalidFurniture_ThrowsException()
        {
            // Arrange
            var bathroom = new Bathroom();
            var bed = new Bed();

            // Act
            bathroom.AddFurniture(bed);
        }

        [TestMethod]
        public void RemoveFurniture_RemovesFurnitureFromList()
        {
            // Arrange
            var bathroom = new Bathroom();
            var chair = new Chair();
            bathroom.AddFurniture(chair);

            // Act
            bathroom.RemoveFurniture(chair);

            // Assert
            Assert.AreEqual(0, bathroom.Furniture.Count);
        }
    }
}
