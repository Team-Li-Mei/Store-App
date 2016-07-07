namespace Store.Core.Models
{
    using Contracts;
    using Infrastructure.Constants;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Not Tested!
    /// </summary>
    public class FlatFileStorage : IDataStorage
    {
        private string fileName;
        private string filePath;

        public FlatFileStorage(string setFileName)
        {
            //Assign FileName
            this.FileName = setFileName;
            //Assign filePath to the current directory/fileName.storageFileExtensionName
            this.filePath = Directory.GetCurrentDirectory() + FileName + Constants.storageFileExtensionName;
            //Create the file which will hold our data
            this.Create();
        }

        public string FileName
        {
            get { return this.fileName; }
            //validation
            private set { this.fileName = FileName; }
        }

        public void Create() => File.Create(filePath);

        public void Delete() => File.Delete(filePath);

        public string Read(int id)
        {
            using (var strReader = new StreamReader(new FileStream(filePath, FileMode.Open), Encoding.UTF8))
            {
                for (int i = 0; i < id; i++)
                {
                    strReader.ReadLine();
                }
                return strReader.ReadLine();
            }
        }

        public void Write(string text)
        {
            using (var strWriter = new StreamWriter(new FileStream(filePath,FileMode.Open), Encoding.UTF8)) 
            {
                strWriter.WriteLine(text);
            }
        }
    }
}
