using System;
using System.Collections.Generic;
using System.Linq;

namespace homework6
{
    internal class Program
    {
        static void Main()
        {
            Taska();

            Console.WriteLine("Нажмите любую клавишу для входа в отсюда...");
            Console.ReadKey();
        }
        static void Taska()
        {
            try
            {
                // Инициализируем 2 роддома
                List<Maternity> maternities = new List<Maternity>();

                Maternity maternity1 = new Maternity("1 роддом РТ", new List<string>() { "Казань", "ул. Деревня Универсиады", "дом 3.1" }, 8, new List<WomanInLabor>(), new List<MedicalStaff>());
                Maternity maternity2 = new Maternity("2 роддом РТ", new List<string>() { "Казань", "ул. Деревня Универсиады", "дом 12" }, 8, new List<WomanInLabor>(), new List<MedicalStaff>());

                maternities.Add(maternity1);
                maternities.Add(maternity2);

                //Делаем 4 работников
                MedicalStaff medicalStaff1 = new MedicalStaff("Арина", "Гомза", "Самый главный", 100000, 0, 2);
                DateTime.TryParse("6.03.2006", out DateTime result1);
                medicalStaff1.BirthDate = result1;
                maternity1.AddStaff(medicalStaff1);


                MedicalStaff medicalStaff2 = new MedicalStaff("Игорь", "Целоусов", "Главный акушер", 10000, 0, 5);
                DateTime.TryParse("1.03.2006", out DateTime result2);
                medicalStaff1.BirthDate = result2;
                maternity1.AddStaff(medicalStaff2);

                MedicalStaff medicalStaff3 = new MedicalStaff("Анна", "Харламова", "Акушер", 20000, 1, 3);
                DateTime.TryParse("1.01.2006", out DateTime result3);
                medicalStaff1.BirthDate = result3;
                maternity2.AddStaff(medicalStaff3);

                MedicalStaff medicalStaff4 = new MedicalStaff("Семен", "Гомза", "Самый главный акушер на районе", 1250, 1, 8);
                DateTime.TryParse("30.12.2005", out DateTime result4);
                medicalStaff1.BirthDate = result4;
                maternity2.AddStaff(medicalStaff4);


                //Инициализируем 6 мам
                WomanInLabor woman1 = new WomanInLabor("Дарья", "Никитина", 1);
                DateTime.TryParse("30.12.1990", out DateTime result5);
                woman1.BirthDate = result5;

                WomanInLabor woman2 = new WomanInLabor("Елена", "Смирнова", 2);
                DateTime.TryParse("15.03.1990", out DateTime result6);
                woman2.BirthDate = result6;

                WomanInLabor woman3 = new WomanInLabor("Анна", "Иванова", 3);
                DateTime.TryParse("22.07.1985", out DateTime result7);
                woman3.BirthDate = result7;

                WomanInLabor woman4 = new WomanInLabor("Ольга", "Петрова", 2);
                DateTime.TryParse("10.11.1992", out DateTime result8);
                woman4.BirthDate = result8;

                WomanInLabor woman5 = new WomanInLabor("Мария", "Кузнецова", 2);
                DateTime.TryParse("05.01.1988", out DateTime result9);
                woman5.BirthDate = result9;

                WomanInLabor woman6 = new WomanInLabor("Татьяна", "Соколова", 1);
                DateTime.TryParse("18.09.1995", out DateTime result10);
                woman6.BirthDate = result10;


                //Инициализируем 11 детей
                Child child1 = new Child("Дима", 3.7, 50, "мама");
                child1.BirthDate = DateTime.Now.AddDays(-14);

                Child child2 = new Child("Саша", 3.5, 45, "папа");
                child2.BirthDate = DateTime.Now.AddDays(-10);

                Child child3 = new Child("Коля", 3.0, 52, "котик");
                child3.BirthDate = DateTime.Now.AddDays(-20);

                Child child4 = new Child("Лена", 3.9, 48, "баба", "гаимлмир");
                child4.BirthDate = DateTime.Now.AddDays(-5);

                Child child5 = new Child("Маша", 3.2, 55, "мама", "мамаааааа");
                child5.BirthDate = DateTime.Now.AddDays(-30);

                Child child6 = new Child("Ваня", 3.8, 46, "мама");
                child6.BirthDate = DateTime.Now.AddDays(-12);

                Child child7 = new Child("Настя", 3.6, 54, "папа");
                child7.BirthDate = DateTime.Now.AddDays(-8);

                Child child8 = new Child("Соня", 4.1, 51, "уууукенгнеавапрорпр", "пить");
                child8.BirthDate = DateTime.Now.AddDays(-25);

                Child child9 = new Child("Рома", 2.9, 79, "баба");
                child9.BirthDate = DateTime.Now.AddDays(-18);

                Child child10 = new Child("Кира", 2.4, 77, "соска");
                child10.BirthDate = DateTime.Now.AddDays(-7);
                
                Child child11 = new Child("Кирилл", 3.1, 77, "есть", "мама");
                child10.BirthDate = DateTime.Now.AddDays(-3);


                //Запихиваем детей в мам
                woman1.AddChild(woman1.Children, child1);
                woman2.AddChild(woman2.Children, child2);
                woman2.AddChild(woman2.Children, child3);
                woman3.AddChild(woman3.Children, child4);
                woman3.AddChild(woman3.Children, child5);
                woman3.AddChild(woman3.Children, child6);
                woman4.AddChild(woman4.Children, child7);
                woman4.AddChild(woman4.Children, child8);
                woman5.AddChild(woman5.Children, child9);
                woman5.AddChild(woman5.Children, child10);
                woman6.AddChild(woman6.Children, child11);

                //Распределяем мам по роддомам
                maternity1.AddPatient(woman1);
                maternity2.AddPatient(woman2);
                maternity1.AddPatient(woman3);
                maternity2.AddPatient(woman4);
                maternity2.AddPatient(woman5);
                maternity1.AddPatient(woman6);

                foreach (var hosp in maternities)
                {
                    Console.WriteLine($"===   {hosp.Name}   ===\n\nПациенты:");
                    hosp.PrintPatient();
                    Console.WriteLine("===   Сотрудники:");
                    hosp.PrintStaff();
                }

                bool flag = true;
                do
                {
                    Console.WriteLine("\nВыберите действие:\nНовый пациент\nДобавить роддом\nДобавить сотрудника\nСписок пациентов\nВыход");
                    string input = Console.ReadLine().ToLower();
                    switch (input)
                    {
                        case "выход":
                            flag = false;
                            break;
                        case "новый пациент":
                            WomanInLabor woman = EnterWoman(maternities);
                            break;
                        case "добавить роддом":
                            AddMaternity(maternities);
                            break;
                        case "добавить сотрудника":
                            MedicalStaff staff = EnterDoctor(maternities);
                            maternities[staff.Hospital].AddStaff(staff);
                            break;
                        case "список пациентов":
                            foreach (var hosp in maternities)
                            {
                                Console.WriteLine($"===   {hosp.Name}   ===\n\nПациенты:");
                                hosp.PrintPatient();
                            }
                            break;
                        default:
                            Console.WriteLine("Я в ответах ограничен. Правильно читайте ТЗ \n(c)I, Robot (2004)");
                            break;
                    }
                }
                while (flag);
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static WomanInLabor EnterWoman(List<Maternity> mats)
        {
            
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            string lastname = Console.ReadLine();

            DateTime birthDate = EnterBirth();

            Console.WriteLine("На сколько человек увеличится население РТ?");
            byte childCount = EnterByte();

            WomanInLabor woman = new WomanInLabor(name, lastname, childCount);
            woman.BirthDate = birthDate;

            for (int i = 0; i < childCount; i++)
            {
                Console.WriteLine($"Введите информацию о {i + 1} ребёнке");
                woman.AddChild(woman.Children, EnterChild());
            }
            bool flag = false;
            for (byte i = 0; i < mats.Count; i++)
            {
                if (mats[i].IsFull())
                {
                    mats[i].AddPatient(woman);
                    flag = true;
                    Console.WriteLine($"Пациент направлен в {mats[i].Name}");
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine("К сожалению, все роддомы заняты(");
            }

            return woman;
        }


        static Child EnterChild()
        {
            Console.WriteLine("Имя ребёнка");
            string name = Console.ReadLine();

            DateTime birthDate = EnterBirth();

            Console.WriteLine("Рост:");
            double height = EnterDouble();

            Console.WriteLine("Вес:");
            double weight = EnterDouble();

            Console.WriteLine("Первое произнесённое слово: ");
            string firstWord = Console.ReadLine();

            Console.WriteLine("Ну и второе:");
            string secondWord = Console.ReadLine();

            Child child = new Child(name, weight, height, firstWord, secondWord);
            child.BirthDate = birthDate;

            return child;
        }


        static MedicalStaff EnterDoctor(List<Maternity> mats)
        {
            Console.WriteLine("Имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Фамилия: ");
            string lastname = Console.ReadLine();

            DateTime birthDate = EnterBirth();

            Console.WriteLine("Профессия:");
            string profession = Console.ReadLine();

            Console.WriteLine("Номер роддома: ");
            byte hospital = EnterMaternity(mats);

            Console.WriteLine("Зарплата: ");
            uint salary = EnterUint();

            Console.WriteLine("Стаж работы:");
            uint workExperience = EnterUint();

            MedicalStaff staff = new MedicalStaff(name, lastname, profession, salary, hospital, workExperience);
            staff.BirthDate = birthDate;

            return staff;
        }
        static void AddMaternity(List<Maternity> mats)
        {
            string name = $"{mats.Count + 1} роддом РТ";
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Введите адрес в формате *город*,*улица*,*дом*");
            List<string> address = Console.ReadLine().Split(',').ToList();
            Console.WriteLine("Сколько пациентов примем?");
            byte capacity = EnterByte();

            Maternity maternity = new Maternity(name, address, capacity, new List<WomanInLabor>(), new List<MedicalStaff>());
            mats.Add(maternity);
            Console.WriteLine("Добавлено");
        }

        /// <summary>
        /// Считывает строку символов с консоли и преобразует ее к целому неотрицательному числу. Ввод продолжается до тех пор, 
        /// пока пользователь не введет число.
        /// </summary>
        /// <returns>Число типа ulong</returns>
        static byte EnterByte()
        {
            bool flag = true;
            byte number;
            do
            {
                bool isNumber = byte.TryParse(Console.ReadLine(), out number);
                if (isNumber)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод - необходимо ввести неотрицательное целое число");
                }
            }
            while (flag);

            return number;
        }

        /// <summary>
        /// Считывает строку символов с консоли и преобразует ее к целому неотрицательному числу. Ввод продолжается до тех пор, 
        /// пока пользователь не введет число.
        /// </summary>
        /// <returns>Число типа ulong</returns>
        static byte EnterMaternity(List<Maternity> materns)
        {
            bool flag = true;
            byte number;
            do
            {
                bool isNumber = byte.TryParse(Console.ReadLine(), out number);
                if (isNumber && 0 <= number && number <= materns.Count)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine($"Неверный ввод - введите число от 1 до {materns.Count}");
                }
            }
            while (flag);

            return --number;
        }

        /// <summary>
        /// Считывает строку символов с консоли и преобразует ее к целому неотрицательному числу. Ввод продолжается до тех пор, 
        /// пока пользователь не введет число.
        /// </summary>
        /// <returns>Число типа ulong</returns>
        static double EnterDouble()
        {
            bool flag = true;
            double number;
            do
            {
                bool isNumber = double.TryParse(Console.ReadLine(), out number);
                if (isNumber)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод - необходимо ввести число без дробной части либо дробное с запятой");
                }
            }
            while (flag);

            return number;
        }
        
        /// <summary>
        /// Считывает строку символов с консоли и преобразует ее к целому неотрицательному числу. Ввод продолжается до тех пор, 
        /// пока пользователь не введет число.
        /// </summary>
        /// <returns>Число типа ulong</returns>
        static uint EnterUint()
        {
            bool flag = true;
            uint number;
            do
            {
                bool isNumber = uint.TryParse(Console.ReadLine(), out number);
                if (isNumber)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод - необходимо ввести натуральное число");
                }
            }
            while (flag);

            return number;
        }

        static DateTime EnterBirth()
        {
            DateTime date = DateTime.Now;
            bool flag = true;
            Console.WriteLine("Введите дату рождения в формате dd.MM.yyyy");
            do
            {
                if (DateTime.TryParse(Console.ReadLine(), out DateTime resultDate) && resultDate < DateTime.Now)
                {
                    date = resultDate;
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Введите реальную дату в формате dd.MM.yyyy");
                }
            }
            while (flag);
            return date;
        }
    }
}
