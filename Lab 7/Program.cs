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
        static private int globalAccount = 1000;
        private int balance;
        private AccountType type;

        public int Account { get => account;}
        public int Balance { get => balance; set => balance = value; }
        public AccountType Type { get => type; set => type = value; }

        public BankAccount()
        {
            account = globalAccount;
            incGlobalAccount(); 
        }

        private void incGlobalAccount()
        {
            globalAccount += 10;
        }

    }




    class Program
    {
        
        static void Main(string[] args)
        {

            BankAccount bankAccount = new BankAccount();
            Console.WriteLine(bankAccount.Account);
            BankAccount bankAccount1 = new BankAccount();
            Console.WriteLine(bankAccount1.Account);
            BankAccount bankAccount2 = new BankAccount();
            Console.WriteLine(bankAccount2.Account);

            Console.ReadKey(); 

        }
    }
}
