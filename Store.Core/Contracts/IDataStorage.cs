namespace Store.Core.Contracts
{
    public interface IDataStorage
    {
        void Create();

        void Write(string text);

        string Read(int id);

        void Delete();
    }
}
