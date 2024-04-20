using ConsoleHeranca.Entities.Accounts;

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

        public override void Withdraw(double amount)
        {
            Balance -= amount;
            // base.Withdraw(amount); /// Aqui é um exemplo que quiser aproveitar o método da classe base, de herança.
            // Balance -=2.0;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
