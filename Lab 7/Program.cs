using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{

    enum AccountType
    {
        Debet,
        Credit

    }


    class BankAccount
    {
        private int account;
        private int balance;
        private AccountType type;

        public int Account { get => account; set => account = value; }
        public int Balance { get => balance; set => balance = value; }
        public AccountType Type { get => type; set => type = value; }

    }




    class Program
    {
        
        static void Main(string[] args)
        {

            BankAccount bankAccount = new BankAccount();
            bankAccount.Account = 1;
            bankAccount.Balance = 0;
            bankAccount.Type = AccountType.Debet;

            Console.ReadKey(); 

        }
    }
}
