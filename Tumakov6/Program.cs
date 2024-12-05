using System;

namespace Tumakov6
{
    internal class Program
    {
        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }

        /// <summary>
        /// Упражнение 7.1. Создать класс счет в банке с закрытыми полями: 
        /// номер счета, баланс, тип банковского счета.
        /// Предусмотреть методы для доступа к данным – заполнения и чтения.
        /// Создать объект класса, заполнить его поля и вывести на печать.
        /// </summary>
        /// <returns>-</returns>
        static void Task1()
        {
            Console.WriteLine("Упражнение 7.1\n");

            BankAccount1 account1 = new BankAccount1();

            Console.WriteLine("Введите номер счёта");
            account1.number = EnterUlong();

            Console.WriteLine("Введите баланс счёта");
            account1.balance = EnterDecimal();

            Console.WriteLine("Введите тип счёта. \n0 - Текущий, 1 - Сберегательный");
            switch (EnterAccType())
            {
                case 0:
                    account1.account = Account.Текущий;
                    break;
                case 1:
                    account1.account = Account.Сберегательный;
                    break;
            }

            account1.PrintInfo();
        }

        /// <summary>
        /// Упражнение 7.2. Создать класс счет в банке с закрытыми полями: 
        /// номер счета, баланс, тип банковского счета.
        /// Счёт генерируется сам + уникален.
        /// Предусмотреть методы для доступа к данным – заполнения и чтения.
        /// Создать объект класса, заполнить его поля и вывести на печать.
        /// </summary>
        /// <returns>-</returns>
        static void Task2()
        {
            Console.WriteLine("Упражнение 7.2\n");

            BankAccount2 account21 = new BankAccount2();

            Console.WriteLine("Введите баланс счёта");
            account21.balance = EnterDecimal();

            Console.WriteLine("Введите тип счёта. \n0 - Текущий, 1 - Сберегательный");
            switch (EnterAccType())
            {
                case 0:
                    account21.account = Account.Текущий;
                    break;
                case 1:
                    account21.account = Account.Сберегательный;
                    break;
            }

            account21.PrintInfo();


            BankAccount2 account22 = new BankAccount2();

            Console.WriteLine("Введите баланс счёта");
            account22.balance = EnterUlong();

            Console.WriteLine("Введите тип счёта. \n0 - Текущий, 1 - Сберегательный");
            switch (EnterAccType())
            {
                case 0:
                    account22.account = Account.Текущий;
                    break;
                case 1:
                    account22.account = Account.Сберегательный;
                    break;
            }

            account22.PrintInfo();
         }

        /// <summary>
        /// Упражнение 7.3. Создать класс счет в банке с закрытыми полями: 
        /// номер счета, баланс, тип банковского счета.
        /// Счёт генерируется сам + уникален.
        /// Добавить 2 метода: положить/снять деньги со счёта.
        /// Предусмотреть методы для доступа к данным – заполнения и чтения.
        /// Создать объект класса, заполнить его поля и вывести на печать.
        /// </summary>
        /// <returns>-</returns>
        static void Task3()
        {
            Console.WriteLine("Упражнение 7.3\n");

            BankAccount3 account3 = new BankAccount3();

            Console.WriteLine("Введите баланс счёта");
            account3.balance = EnterDecimal();

            Console.WriteLine("Введите тип счёта. \n0 - Текущий, 1 - Сберегательный");
            switch (EnterAccType())
            {
                case 0:
                    account3.account = Account.Текущий;
                    break;
                case 1:
                    account3.account = Account.Сберегательный;
                    break;
            }
            account3.PrintInfo();

            Console.WriteLine("Выберите операцию:\nСнять деньги со счёта\nПоложить деньги на счёт");
            bool flag2 = true;
            do {
                string input = Console.ReadLine().ToLower();
                if (input.StartsWith("сня"))
                {
                    Console.WriteLine("Введите сумму");
                    bool flag = true;
                    do
                    {
                        decimal summa = EnterDecimal();
                        if (account3.Remove(summa))
                        {
                            Console.WriteLine("Сумма успешно снята");
                            flag = false;
                            flag2 = false;
                        }
                        else
                        {
                            Console.WriteLine("Невозможно снять эту сумму, ваши ожидания превышены");
                            Console.WriteLine("Введите другие циферки, поменьше");
                        }
                    }
                    while (flag);
                }
                else if (input.StartsWith("поло"))
                {
                    Console.WriteLine("Введите сумму");
                    decimal summ = EnterDecimal();
                    account3.Put(summ);
                    flag2 = false;
                }
                else
                {
                    Console.WriteLine("Некорректная операция, попробуйте снова");
                }
            }
            while (flag2);
            account3.PrintInfo();
        }

        /// <summary>
        /// Домашнее задание 7.1. Реализовать класс для описания здания 
        /// (уникальный номер здания, высота, этажность, количество квартир, подъездов). 
        /// Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати.
        /// Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества
        /// квартир на этаже и т.д. Предусмотреть возможность, чтобы уникальный номер здания генерировался программно.
        /// </summary>
        /// <returns>-</returns>
        static void Task4()
        {
            Console.WriteLine("Домашнее задание 7.1");

            bool flag = true;
            do
            {
                Console.WriteLine("Введите действие - новое здание / выход");
                string input = Console.ReadLine().ToLower();
                if (input.StartsWith("новое"))
                {
                    Building building = new Building();

                    Console.WriteLine("Введите высоту дома в метрах");
                    building.height = EnterUint();

                    Console.WriteLine("Введите количество подъездов в доме");
                    building.countEntrance = EnterUint();

                    Console.WriteLine("Введите количество этажей в доме");
                    bool br = true;
                    do
                    {
                        uint countFloor = EnterUint();
                        if (building.height / countFloor < 2.23333)
                        {
                            Console.WriteLine("Низковато. Семён не пройдёт. Давайте по новой");
                        }
                        else
                        {
                            br = false;
                            building.countFloors = countFloor;
                        }
                    }
                    while (br);
                    
                    Console.WriteLine("Введите количество квартир в доме");
                    br = true;
                    do
                    {
                        uint countFlats = EnterUint();
                        if (countFlats % (building.countEntrance * building.countFloors) != 0 )
                        {
                            Console.WriteLine($"Количество квартир должно делиться на {building.countEntrance * building.countFloors}");
                        }
                        else
                        {
                            building.countFlat = countFlats;
                            br  = false;
                        }
                    }
                    while (br);
                    
                    //Вывод
                    Console.WriteLine($"Номер дома: {building.number}");
                    Console.WriteLine($"Высота: {building.height}");
                    Console.WriteLine($"Этажность: {building.countFloors}");
                    Console.WriteLine($"Количество подъездов: {building.countEntrance}");
                    Console.WriteLine($"Количество квартир: {building.countFlat}");
                    Console.WriteLine($"Квартир в подъезде: {building.FlatsInEntrance()}");
                    Console.WriteLine($"Квартир на этаже: {building.FlatsOnFloor()}");
                    Console.WriteLine($"Высота этажа - {building.FloorsHeight()} м");
                }
                else if (input.StartsWith("выход"))
                { 
                    flag = false;
                }
            } while (flag);

        }
        
        /// <summary>
        /// Считывает строку символов с консоли и преобразует ее к 0 либо 1. Ввод продолжается до тех пор, 
        /// пока пользователь не введет число.
        /// </summary>
        /// <returns>Число типа byte</returns>
        static byte EnterAccType()
        {
            bool flag = true;
            byte number;
            do
            {
                bool isNumber = byte.TryParse(Console.ReadLine(), out number);
                if (isNumber && number < 2)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод - необходимо ввести 0 либо 1");
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
        static ulong EnterUlong()
        {
            bool flag = true;
            ulong number;
            do
            {
                bool isNumber = ulong.TryParse(Console.ReadLine(), out number);
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
        /// Считывает строку символов с консоли и преобразует ее к неотрицательному числу. Ввод продолжается до тех пор, 
        /// пока пользователь не введет число.
        /// </summary>
        /// <returns>Число типа decimal</returns>
        static decimal EnterDecimal()
        {
            bool flag = true;
            decimal number;
            do
            {
                bool isNumber = decimal.TryParse(Console.ReadLine(), out number);
                if (isNumber && number >= 0)
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
        /// Считывает строку символов с консоли и преобразует ее к натуральному числу. Ввод продолжается до тех пор, 
        /// пока пользователь не введет число.
        /// </summary>
        /// <returns>Число типа uint</returns>
        static uint EnterUint()
        {
            bool flag = true;
            uint number;
            do
            {
                bool isNumber = uint.TryParse(Console.ReadLine(), out number);
                if (isNumber && number > 0)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод - необходимо ввести положительное целое число");
                }
            }
            while (flag);

            return number;
        }
    }

    /// <summary>
    /// Перечисление типов банковских аккаунтов
    /// </summary>
    enum Account
    {
        Сберегательный,
        Текущий
    }
}
    
