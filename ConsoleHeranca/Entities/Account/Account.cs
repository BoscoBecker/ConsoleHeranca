namespace ConsoleHeranca.Entities.Accounts
{
    internal class Account
    {
        public int number { get; protected set; }
        public string holder { get; protected set; }
        public double Balance { get; protected set; }

        public virtual void Withdraw(double amount)
        {
            this.Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public Account(){ }

        public Account(int number, string holder, double balance, double balance1)
        {
            this.number = number;
            this.holder = holder;
            this.Balance = balance;
        }

        public Account(int number, string holder, double balance)
        {
            this.number = number;
            this.holder = holder;
            this.Balance = balance;
        }
    }
}