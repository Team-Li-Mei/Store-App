namespace Store.Core.Models
{
    using Contracts;
    using Infrastructure.Constants;

    public class DataStorageFactory
    {
        static public IDataStorage CreateDbContext(string fileName)
        {
            //ToDo get from .config file
            string storageSystemName = Constants.dataStorageName;

            IDataStorage storageSystem = null;

            switch (storageSystemName)
            {
                case "FileStorage":
                    storageSystem = new FileStorage(fileName);
                    break;
                default:
                    break;
            }
            return storageSystem;
        }
    }
}
