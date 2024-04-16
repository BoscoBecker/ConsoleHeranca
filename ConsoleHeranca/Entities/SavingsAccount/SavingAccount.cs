using ConsoleHeranca.Entities.Accounts;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleHeranca.Entities.SavingsAccount
{
    class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount() { }
        public SavingAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance, balance)
        { 
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            balance += balance * InterestRate;
        }
    }
}
