using System;

namespace Tumakov6
{
    internal class BankAccount2
    {
        private static ulong _Number = 0;
        private decimal _Balance;
        private Account _account;
        

        public ulong number
        { get { return _Number++; } }
        
        public decimal balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }
        public Account account
        {
            get { return _account; }
            set { _account = value; }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Номер счёта: {number}, баланс: {balance}, тип: {account}");
        }
    }
}
