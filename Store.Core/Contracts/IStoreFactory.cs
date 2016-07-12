namespace Store.Core.Contracts
{
    using System;

    public interface IStoreFactory
    {
        IDataStorage CreateDataStorage(string setFileName);

        IUser CreateUser(Type type, string setUsername, string setPassword, string setEmail);
    }
}
