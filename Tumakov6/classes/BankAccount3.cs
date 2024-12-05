using System;
using System.Linq.Expressions;

namespace Tumakov6
{
    internal class BankAccount3
    {
        #region Fields
        private static ulong _Number = 0;
        private decimal _Balance;
        private Account _account;
        #endregion

        #region Properties
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
        #endregion

        #region Methods

        /// <summary>
        /// Выводит информацию о банковском счёте
        /// </summary>
        /// <returns>-</returns>
        public void PrintInfo()
        {
            Console.WriteLine($"Номер счёта: {number}, баланс: {balance}, тип: {account}");
        }

        /// <summary>
        /// Добавляет введённую сумму к сумме на счету. 
        /// </summary>
        /// <returns>-</returns>
        public void Put(decimal moneyy)
        {
            _Balance += moneyy;
            Console.WriteLine("Сумма успешно положена");
        }

        /// <summary>
        /// Проверяет, можно ли снять введённую сумму.
        /// Если да, то вычитает её со счёта, 
        /// в противном случае уведомляет пользователя о невозможности операции.
        /// </summary>
        /// <returns>Значение типа bool</returns>
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
        #endregion
    }
}
