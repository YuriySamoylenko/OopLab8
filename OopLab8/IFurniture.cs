namespace OopLab8
{
    public interface IFurniture
    {
        int NumberOfLegs { get; }

        Place Place { get; }

        void Move(Place place);
    }
}
