namespace Store.Core.Models.Users.Abstract
{
    using Contracts;
    using System;
    using System.Text;

    /// <summary>
    /// Concrete Component
    /// </summary>
    public abstract class User : IUser
    {
        private string username;
        private string password;
        private string email;
        private static int id = 0;

        private Wallet wallet;

        public User(string setUsername, string setPassword, string setEmail)
        {
            id++;
            this.Username = setUsername;
            this.Password = setPassword;
            this.Email = setEmail;
            this.wallet = new Wallet(0);
        }

        public int Id
        {
            get { return id; }
        }

        public string Email
        {
            get { return this.email; }
            protected set
            {
                this.email = value; //ToDo validate
            }
        }

        public string Password
        {
            get { return this.password; }
            protected set
            {
                this.password = value; //ToDo validate
            }
        }

        public string Username
        {
            get { return this.username; }
            protected set
            {
                this.username = value; //ToDo validate
            }
        }

        public Wallet Wallet { get { return this.wallet; } set { this.wallet = value; } }

        public void AddItem(IProduct product)
        {
            Console.WriteLine(product);
        }

        public void RemoveItem(IProduct product)
        {
            Console.WriteLine(product);
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();
            strBuilder.Append($"{this.Id}|{this.Username}|{this.Password}|{this.Wallet}|{this.Email}");
            return strBuilder.ToString();
        }
    }
}
