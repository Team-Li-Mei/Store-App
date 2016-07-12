using Store.Core.Infrastructure.Constants;
using Store.Core.Infrastructure.Utils;

namespace Store.Core.Models
{
    public struct Wallet
    {
        private decimal balance;

        public Wallet(decimal setMoneyAmmount)
        {
            this.balance = 0;
            this.Balance = setMoneyAmmount;
        }

        public decimal Balance
        {
            get { return this.balance; }
            private set
            {
                Validator.CheckIfDecimalRange(value, GeneralConstants.MinPrice, GeneralConstants.MaxPrice, string.Format(
                    GeneralConstants.NumberMustBeBetweenMinAndMax, "Balance", GeneralConstants.MinPrice, GeneralConstants.MaxPrice));

                this.balance = value;
            }
        }

        public void AddMoney(decimal ammount)
        {
            Validator.CheckIfDecimalRange(ammount + this.balance, GeneralConstants.MinPrice, GeneralConstants.MaxPrice, string.Format(
                GeneralConstants.NumberMustBeBetweenMinAndMax, "Balance", GeneralConstants.MinPrice, GeneralConstants.MaxPrice));

            this.balance += ammount;
        }

        public void RemoveMoney(decimal ammount)
        {
            Validator.CheckIfDecimalRange(ammount - this.balance, GeneralConstants.MinPrice, GeneralConstants.MaxPrice, string.Format(
                GeneralConstants.NumberMustBeBetweenMinAndMax, "Balance", GeneralConstants.MinPrice, GeneralConstants.MaxPrice));

            this.balance -= ammount;
        }
    }
}
