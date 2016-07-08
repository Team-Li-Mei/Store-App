namespace Store.Core.Models
{
    public struct Wallet
    {
        private decimal balance;

        public Wallet(decimal setMoneyAmmount)
        {
            //validate
            this.balance = setMoneyAmmount;
        }

        public void AddMoney(decimal ammount)
        {
            //validate
            this.balance += ammount;
        }

        public void RemoveMoney(decimal ammount)
        {
            //validate
            this.balance -= ammount;
        }
    }
}
