namespace OopLab8
{
    public class Bathroom : IRoom
    {
        public IList<IFurniture> Furniture { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Area { get => throw new NotImplementedException(); }

        public void AddFurniture(IFurniture furniture)
        {
            throw new NotImplementedException();
        }

        public void RemoveFurniture(IFurniture furniture)
        {
            throw new NotImplementedException();
        }
    }
}
