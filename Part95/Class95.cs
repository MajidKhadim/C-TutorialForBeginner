using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part95
{
    internal class Class95
    {
        public static void MainFunction()
        {
            Console.WriteLine("Main Started");
            Account account1 = new Account(101,5000);
            Account account2 = new Account(102,3000);

            AccountManager accountManagerA = new AccountManager(account1, account2, 1000);

            Thread t1 = new Thread(accountManagerA.Transfer);
            t1.Name = "T1";

            AccountManager accountManagerB = new AccountManager(account2, account1, 2000);

            Thread t2 = new Thread(accountManagerB.Transfer);
            t1.Name = "T2";

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
            Console.WriteLine("Main Completed");

        }

    }

    
    class AccountManager
    {
        Account _fromAccount;
        Account _toAccount;
        double _amountToTransfer;
        public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _amountToTransfer = amountToTransfer;
        }
        public void Transfer()
        {
            lock (_fromAccount) 
            {
                Thread.Sleep(1000);
                lock (_toAccount)
                {
                    _fromAccount.WithDraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);
                }
            }
        }
    }
    public class Account
    {
        double _balance;
        int _id;

        public Account(int id,double balance)
        {
            _id = id;
            _balance = balance;
        }

        public int ID {  get { return _id;} }

        public void WithDraw(double amount)
        {
            _balance -= amount;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }
    }

}
