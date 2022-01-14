using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorials
{
    public class ClassKendra101
    {
        public ClassKendra101(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            this.Owner = name;
            this.Balance = initialBalance;
        }

        public ClassKendra101()
        {
        }

        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }

        private static int accountNumberSeed = 1234567890;

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
        }

        public static void BankClient()
        {
            var account = new ClassKendra101("Alex", 100000);
            Console.WriteLine($"Account number: {account.Number}, was created for {account.Owner} with {account.Balance} $.");
        }
    }

}
