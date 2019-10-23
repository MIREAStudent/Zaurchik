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

        public void pullAccount(int sum)
        {
            if (this.balance > sum)
                this.balance -= sum;
            else
                Console.WriteLine("Недостаточно средств");
        }

        public void pushAccount(int sum)
        {
            this.balance += sum;
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


            bankAccount.Balance = 1000;
            bankAccount.pullAccount(2000);
            bankAccount.pullAccount(500);

            Console.WriteLine(bankAccount.Balance);

            bankAccount.pushAccount(2000);

            Console.WriteLine(bankAccount.Balance); 

         


            Console.ReadKey(); 

        }
    }
}
