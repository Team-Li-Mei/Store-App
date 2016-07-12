namespace Store.Core.Models
{
    public struct Wallet
    {
        private decimal balance;

        public decimal Balance
        {
            get { return this.balance; }
            private set
            {
                //validate
                this.balance = value;
            }
        }

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
