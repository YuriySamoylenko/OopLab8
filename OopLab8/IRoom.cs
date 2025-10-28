namespace OopLab8
{
    public interface IRoom
    {
        IList<IFurniture> Furniture { get; set; }

        float Area { get; }

        void AddFurniture(IFurniture furniture);

        void RemoveFurniture(IFurniture furniture);
    }
}
