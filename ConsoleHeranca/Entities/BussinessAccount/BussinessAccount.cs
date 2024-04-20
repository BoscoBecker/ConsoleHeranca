using ConsoleHeranca.Entities.Accounts;
using System.Text;

namespace ConsoleHeranca.Entities.BussinessAccount
{
    class BussinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public void Loan(double amount)
        {
            if ( amount <= LoanLimit)
            {
                this.Balance += amount;
            }
            
        }
        public BussinessAccount()
        {
        }
        public BussinessAccount(double loanLimit)
        {
            this.LoanLimit = loanLimit;
        }

        public BussinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            this.LoanLimit = loanLimit;
        }

        public override string ToString()
        {
            StringBuilder sbAccount = new StringBuilder();
            sbAccount.AppendLine("Number Acccount: " + this.number);
            sbAccount.AppendLine("User: " + this.holder);
            sbAccount.AppendLine("Current Balance: " + this.Balance);
            return sbAccount.ToString();

        }
    }
}
