using ConsoleHeranca.Entities.Accounts;
using ConsoleHeranca.Entities.BussinessAccount;
using ConsoleHeranca.Entities.SavingsAccount;

namespace ConsoleHeranca {

    class Program {

        public static void Main(string[] args) {


            BussinessAccount Ba = new BussinessAccount(2040,"Joao Bosco",200, 300);

            /*         **UPCASTING**       */

            Account acc1 = Ba;
            Account acc2 = new BussinessAccount(2040, "Joao", 0.0, 500.00);
            Account acc3 = new SavingAccount(2040, "Maria", 20.00, 0.01);            

            /*        **DOWNCASTING** UNSAFE    */
            BussinessAccount acc4 = (BussinessAccount)acc2;
                             acc4.Loan(500.50); /// Yes, Method of BussinessAccount class
            //BussinessAccount acc5 = (BussinessAccount)acc3;/// Sintaxe OK,  but run-time erro, different types
            //BussinessAccount acc5 = acc3 as BussinessAccount; Another way using as
            if (acc3 is BussinessAccount) {
                BussinessAccount acc5 = (BussinessAccount)acc3;
                
            }

            if (acc3 is SavingAccount) {
                SavingAccount acc5 = (SavingAccount)acc3;
                acc5.UpdateBalance();
            
            }

            Console.WriteLine(Ba);
        }
    
    }



}