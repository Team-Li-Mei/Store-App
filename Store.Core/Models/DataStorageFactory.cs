namespace Store.Core.Models
{
    using Contracts;
    using Infrastructure.Constants;

    public class DataStorageFactory
    {
        static public IDataStorage CreateDbContext(string fileName)
        {
            string storageSystemName = GeneralConstants.DataStorageName;

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
