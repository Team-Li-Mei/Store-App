namespace Store.Core.Models
{
    using System;
    using Contracts;
    using Users;
    using Infrastructure.Constants;

    public class StoreFactory : IStoreFactory
    {
        private static StoreFactory instance;

        public static StoreFactory Instance
        {
            get
            {
                if (instance == null)
                    instance = new StoreFactory();
                return instance;
            }
        }

        public IDataStorage CreateDataStorage(string setFileName)
        {
            return DataStorageFactory.CreateDbContext(setFileName);
        }

        public IUser CreateUser(Type type, string setUsername, string setPassword, string setEmail)
        {
            var userType = type.Name.ToString();
            switch (userType)
            {
                case "Admin":
                    return new Admin(setUsername, setPassword, setEmail);
            }

            throw new ArgumentException(String.Format(GeneralConstants.InvalidUserType, userType));
        }


    }
}
