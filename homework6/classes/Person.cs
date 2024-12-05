using System;

namespace homework6
{
    internal abstract class Person
    {
        #region Fields
        private string _Name;
        private string _Lastname;
        private DateTime _BirthDate;
        private static ulong _PassportSeria = 7530;
        private static ulong _PassportNumber = 1;
        #endregion

        #region Properties
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Lastname
        {
            get { return _Lastname; }
            set { _Lastname = value; }
        }
        public DateTime BirthDate
        {
            get { return _BirthDate; }
            set { _BirthDate = value; }
        }
        public ulong PassportSeria
        {
            get { return _PassportSeria; }
        }
        public ulong PassportNumber
        {
            get { return _PassportNumber++; }
        }
        #endregion

        #region Methods
        public virtual void ShowInfo()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{Lastname}");
            Console.WriteLine($"Возраст: {GetAge(BirthDate)}");
            Console.WriteLine($"Паспорт: {PassportSeria}{PassportNumber.ToString("D6")}\n");
        }
        public int GetAge(DateTime birthday)
        {
            DateTime now = DateTime.Today;

            int age = now.Year - birthday.Year;
            if (birthday > now.AddYears(-age))
            {
                age--;
            }
            return age;
        }
        #endregion
    }
}
