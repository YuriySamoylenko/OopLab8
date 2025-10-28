namespace OopLab8.Tests
{
    [TestClass]
    public class ApartmentTests
    {
        [TestMethod]
        public void Apartment_InitializedProperly()
        {
            // Arrange
            var apartment = new Apartment();

            // Act
            var rooms = apartment.GetRooms();

            // Assert
            Assert.IsNotNull(rooms);
            Assert.AreEqual(4, rooms.Count);
        }
    }
}
