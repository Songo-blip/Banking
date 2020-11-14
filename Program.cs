using System;
using Banking;

namespace Banks
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank songo = new Bank("Songo", 7222, "Strand");
            Customer myNewCustomer = new Customer("8198373764", "city of cape town ", "Sipho", "Administrator");
            songo.AddCustomer(myNewCustomer);

            var account = myNewCustomer.ApplyForBankAccount();
            account.DepositMoney(20000, DateTime.Now, "Salary");

            try
            {
                account.WithdrawMoney(300, DateTime.Now, "Buy Grossaries");
                account.WithdrawMoney(2000, DateTime.Now, "Pay Rent");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message + " contact administrator.");
            }

            Console.WriteLine("Current Balance :" + account.Balance);

            var history = account.GetTransactionHistory();

            Console.WriteLine(history);
        }
    }
}
