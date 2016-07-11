namespace Store.Core.Models
{
    using Contracts;
    using Infrastructure.Constants;
    using Infrastructure.Utils;
    using System.IO;
    using System.Text;

    public class FileStorage : IDataStorage
    {
        private string fileName;
        private string filePath;

        public FileStorage(string setFileName)
        {
            this.FileName = setFileName;
            this.filePath = FileName + GeneralConstants.storageFileExtensionName;
            this.Create();
        }

        public string FileName
        {
            get { return this.fileName; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, GeneralConstants.FileStorageNameMaxLength, GeneralConstants.FileStorageNameMinLength,
                string.Format(GeneralConstants.InvalidStringLength, "FileName", GeneralConstants.FileStorageNameMinLength, GeneralConstants.FileStorageNameMaxLength));
                this.fileName = value;
            }
        }

        public void Create()
        {
            if (!File.Exists(filePath))
                File.Create(filePath).Close();
        }

        public void Delete()
        {
            File.Delete(filePath);
        }

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
