namespace Store.Core.Models.Users
{
    using Abstract;

    public class Admin : User
    {
        public Admin(string setUsername, string setPassword, string setEmail)
            : base(setUsername, setPassword, setEmail)
        {
        }
    }
}
