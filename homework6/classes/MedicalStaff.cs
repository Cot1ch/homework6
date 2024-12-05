using System;

namespace homework6
{
    internal class MedicalStaff : Person
    {
        #region Fields
        private string _Profession;
        private uint _Salary;
        private byte _Hospital;
        private uint _WorkExperience;
        #endregion

        #region Properties
        public MedicalStaff(string name, string lastname, string profession, uint salary, byte hospital, uint work)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Profession = profession;
            this.Salary = salary;
            this.Hospital = hospital;
            this.WorkExperience = work;
        }

        public string Profession
        {
            get { return _Profession; }
            set { _Profession = value; }
        }
        public uint Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public byte Hospital
        {
            get { return _Hospital; }
            set { _Hospital = value; }
        }
        public uint WorkExperience
        {
            get { return _WorkExperience; }
            set { _WorkExperience = value; }
        }
        #endregion

        #region Methods
        public override void ShowInfo()
        {
            Console.WriteLine($"\n{Name} {Lastname}");
            Console.WriteLine($"Возраст: {GetAge(BirthDate)}");
            Console.WriteLine($"Паспорт: {PassportSeria} {PassportNumber.ToString("D6")}");
            Console.WriteLine($"Специализация: {_Profession}");
            Console.WriteLine($"Кабинет: {_Hospital}");
            Console.WriteLine($"Зарплата: {_Salary}");
            Console.WriteLine($"Стаж работы: {_WorkExperience}");
        }
        #endregion
    }
}
