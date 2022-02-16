using System;

namespace netcore_banking
{
    class Banking
    {
        static void Main(string[] args)
        {
            Account my_account = new Account("Elric", 1_000_000);
            Account other_account = new Account("Elrico", 1_000_000);
            
            my_account.Withdraw(11, 500_000);
            my_account.DisplayBalance(1234);
            my_account.Withdraw(1234, 500_000);
            my_account.DisplayBalance(1234);
            other_account.DisplayBalance(1234);
        }
    }
    class Account
    {
        private string name;
        private int balance;


        public Account(string name, int balance = 100)
        {
            this.name = name;
            this.balance = balance;
        }

        public void DisplayBalance(int pinNumber) =>
                Console.WriteLine(pinNumber == Pin() ? $"Balance: {balance}." : PinError());

        public void Withdraw(int pinNumber, int amount)
        {
            if (pinNumber == Pin())
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount}. New balance: {balance}.");
            }
            else
            {
                Console.WriteLine(PinError());
            }
        }

        private int Pin()
        {
            int pin = 1234;
            return pin;


        }
        private string PinError()
        {
            return "Access denied: incorrect PIN";
        }

    }
}
