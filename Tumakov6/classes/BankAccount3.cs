using System;
using System.Linq.Expressions;

namespace Tumakov6
{
    internal class BankAccount3
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
        public void Put(decimal moneyy)
        {
            _Balance += moneyy;
            Console.WriteLine("Сумма успешно положена");
        }
        public bool Remove(decimal moneyy)
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
