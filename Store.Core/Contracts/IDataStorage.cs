namespace Store.Core.Contracts
{
    public interface IDataStorage
    {
        void Create();

        void Read();

        void Update();

        void Delete();
    }
}
