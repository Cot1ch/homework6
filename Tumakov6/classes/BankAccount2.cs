using System;

namespace Tumakov6
{
    internal class BankAccount2
    {
        #region Fields
        private static ulong _Number = 0;
        private decimal _Balance;
        private Account _account;
        #endregion

        #region Properties
        public ulong number
        { 
            get { return _Number++; } 
        }
        
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
        #endregion

        #region Method
        /// <summary>
        /// Выводит информацию о банковском счёте
        /// </summary>
        /// <returns>-</returns>
        public void PrintInfo()
        {
            Console.WriteLine($"Номер счёта: {number}, баланс: {balance}, тип: {account}");
        }
        #endregion
    }
}
