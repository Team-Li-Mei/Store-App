namespace Store.Core.Models.Users
{
    using Contracts;
    using System;
    using Common;

    /// <summary>
    /// Concrete Component
    /// </summary>
    public class User : IUser
    {
        private string username;
        private string password;
        private string email;
        private string id;

        public User(string setUsername, string setPassword, string setEmail)
        {
            this.Id = new Guid().ToString();
            this.Username = setUsername;
            this.Password = setPassword;
            this.Email = setEmail;
        }

        public string Id
        {
            get { return this.id; }
            protected set
            {
                this.id = value; //ToDo validate
            }
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

        public void AddItem(Item item)
        {
            Console.WriteLine(item);
        }

        public void RemoveItem(Item item)
        {
            Console.WriteLine(item);
        }
    }
}
