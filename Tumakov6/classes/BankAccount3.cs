using System;

namespace Tumakov6
{
    internal class BankAccount3
    {
        private static ulong _Number = 0;
        private ulong _Balance;
        private Account _account;


        public ulong number
        { get { return _Number++; } }

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
        public void Put(ulong moneyy)
        {
            _Balance += moneyy;
            Console.WriteLine("Сумма успешно положена");
        }
        public bool Remove(ulong moneyy)
        {
            if (moneyy <= _Balance)
            {
                _Balance -= moneyy;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
