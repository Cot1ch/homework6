using System;

namespace Tumakov6
{
    internal class BankAccount1
    {
        private ulong _Number;
        private ulong _Balance;
        private Account _account;

        public ulong number
        {
            get { return _Number; }
            set { _Number = value; }
        }
        public ulong balance
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
