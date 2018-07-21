using System;
namespace ConsoleStaticProperties
{
    class SavingsAcount
    {
        public double currBalance;

        private static double currInterestRate = 0.04;

        public static double interestRate
        {
            get { return currInterestRate; }
            set { currInterestRate = value; }
        }

        public SavingsAcount(){}
    }
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAcount savingsAccount = new SavingsAcount();
            savingsAccount.currBalance = 0.05;

            Console.WriteLine(savingsAccount.currBalance);
            Console.Read();
        }
    }
}
