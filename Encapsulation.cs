using System;

namespace Encapsulation
{
    // Example 1
    public class Human
    {
        //By using Get & Set we can set value of the variables 
        private string HumanName;
        private int HumanAge;
        public string name
        {
            get { return HumanName; }
            set { HumanName = value; }
        }
        public int age
        {
            get { return HumanAge; }
            set { HumanAge = value; }
        }
    }
    // example 2 Bank Account 
    public class Myaccount
    {
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public decimal Deposit
        {
            get { return balance; }
            set { balance += value; }

        }
        public decimal Withdraw
        {
            get { return balance; }
            set
            {
                if (balance >= value)
                {
                    balance -= value;
                }
                else
                {
                    Console.WriteLine(" Not sufficient Balance");
                }
            }
        }
    }
}