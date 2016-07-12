namespace Store.Core.Models.Users.Abstract
{
    using Carts;
    using Contracts;
    using Infrastructure.Constants;
    using Infrastructure.Utils;
    using System;
    using System.Text;

    public abstract class User : IUser
    {
        private string firstname;
        private string lastname;
        private string username;
        private string password;
        private string email;
        private static int id = 0;

        private Wallet wallet;
        private ICart cart;

        public User(string setUsername, string setPassword, string setEmail)
        {
            id++;

            this.Username = setUsername;
            this.Password = setPassword;
            this.Email = setEmail;

            this.wallet = new Wallet();
            this.cart = new Cart();
        }
        public ICart Cart
        {
            get
            {
                return this.cart;
            }
            protected set
            {
                this.cart = value;
            }
        }

        public int Id { get { return id; } }

        public string Email
        {
            get { return this.email; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, GeneralConstants.MaxEmaiLength, GeneralConstants.MaxEmaiLength,
                    string.Format(GeneralConstants.StringMustBeBetweenMinAndMax, "Email", GeneralConstants.MinEmailLength, GeneralConstants.MaxEmaiLength));
                Validator.CheckSymbols(value, GeneralConstants.EmailPattern,
                    string.Format(GeneralConstants.InvalidSymbols, "Email"));

                this.email = value;
            }
        }

        public string Password
        {
            get { return this.password; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, GeneralConstants.MaxPasswordLength, GeneralConstants.MinPasswordLength,
                   string.Format(GeneralConstants.StringMustBeBetweenMinAndMax, "Email", GeneralConstants.MinPasswordLength, GeneralConstants.MaxPasswordLength));
                Validator.CheckSymbols(value, GeneralConstants.PasswordPattern,
                    string.Format(GeneralConstants.InvalidSymbols, "Password"));
                this.password = value;
            }
        }

        public string Username
        {
            get { return this.username; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, GeneralConstants.MaxNameLength, GeneralConstants.MinNameLength,
                   string.Format(GeneralConstants.StringMustBeBetweenMinAndMax, "Username", GeneralConstants.MinNameLength, GeneralConstants.MaxNameLength));
                Validator.CheckSymbols(value, GeneralConstants.UsernamePattern,
                    string.Format(GeneralConstants.InvalidSymbols, "Username"));

                this.username = value;
            }
        }

        public string Firstname
        {
            get { return this.firstname; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, GeneralConstants.MaxNameLength, GeneralConstants.MinNameLength,
                       string.Format(GeneralConstants.StringMustBeBetweenMinAndMax, "Firstname", GeneralConstants.MinNameLength, GeneralConstants.MaxNameLength));
                Validator.CheckSymbols(value, GeneralConstants.UsernamePattern,
                    string.Format(GeneralConstants.InvalidSymbols, "Firstname"));

                this.firstname = value;
            }
        }

        public string Lastname
        {
            get { return this.lastname; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, GeneralConstants.MaxNameLength, GeneralConstants.MinNameLength,
                       string.Format(GeneralConstants.StringMustBeBetweenMinAndMax, "Lastname", GeneralConstants.MinNameLength, GeneralConstants.MaxNameLength));
                Validator.CheckSymbols(value, GeneralConstants.UsernamePattern,
                    string.Format(GeneralConstants.InvalidSymbols, "Lastname"));

                this.lastname = value;
            }
        }

        public Wallet Wallet { get { return this.wallet; } set { this.wallet = value; } }

        public virtual void AddItem(IProduct product)
        {
            this.Cart.AddToCart(product);
        }

        public virtual void RemoveItem(IProduct product)
        {
            this.Cart.RemoveFromCart(product);
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();
            strBuilder.Append($"{this.Id}|{this.Username}|{this.Password}|{this.Wallet}|{this.Email}");
            return strBuilder.ToString();
        }
    }
}
