namespace Store.Core.Models
{
    using Contracts;
    using Infrastructure.Constants;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Not Tested Much!
    /// </summary>
    public class FileStorage : IDataStorage
    {
        private string fileName;
        private string filePath;

        public FileStorage(string setFileName)
        {
            //Assign FileName
            this.FileName = setFileName;
            //Assign filePath to the current directory/fileName.storageFileExtensionName
            this.filePath = FileName + Constants.storageFileExtensionName;
            //Create the file which will hold our data
            this.Create();
        }

        public string FileName
        {
            get { return this.fileName; }
            //validation
            private set { this.fileName = value; }
        }

        public void Create()
        {
            if (!File.Exists(filePath))
                File.Create(filePath).Close();
        }

        public void Delete() => File.Delete(filePath);

        public string Read(int id)
        {
            using (var strReader = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read), Encoding.UTF8))
            {
                for (int i = 0; i < id - 1; i++)
                {
                    strReader.ReadLine();
                }
                return strReader.ReadLine();
            }
        }

        public string ReadToEnd()
        {
            using (var strReader = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read), Encoding.UTF8))
            {
                return strReader.ReadToEnd();
            }
        }

        public void Write(string text)
        {
            using (var strWriter = new StreamWriter(new FileStream(filePath, FileMode.Append, FileAccess.Write), Encoding.UTF8))
            {
                strWriter.WriteLine(text);
            }
        }
    }
}
