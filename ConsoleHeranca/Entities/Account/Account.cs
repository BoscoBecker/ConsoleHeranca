namespace ConsoleHeranca.Entities.Accounts
{
    class Account
    {
        public int number { get; protected set; }
        public string holder { get; protected set; }
        public double balance { get; protected set; }


        public void Withdraw(double amount)
        {
            this.balance -= amount;
        }

        public void Deposit(double amount)
        {
            this.balance += amount;

        }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double balance1)
        {
            this.number = number;
            this.holder = holder;
            this.balance = balance;
        }

        public Account(int number, string holder, double balance)
        {
            this.number = number;
            this.holder = holder;
            this.balance = balance;
        }
    }
}
