using System;

namespace homework6
{

    internal class Child : Person
    {
        private double _Weight;
        private double _Height;
        private string _FirstWord;
        private string _SecondWord;

        public Child(string name, double weight, double height, string firstword, string secondword)
        {
            this.Name = name;
            this.Weight = weight;
            this.Height = height;
            this.FirstWord = firstword;
            this.SecondWord = secondword;
        }
        public Child(string name, double weight, double height, string firstword)
        {
            this.Name = name;
            this.Weight = weight;
            this.Height = height;
            this.FirstWord = firstword;
        }

        public double Weight
        { get { return _Weight; } set { _Weight = value; } }
        public double Height
        { get { return _Height; } set { _Height = value; } }
        public string FirstWord
        { get { return _FirstWord; } set { _FirstWord = value; } }
        public string SecondWord
        { get { return _SecondWord; } set { _SecondWord = value; } }

        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} {Lastname}");
            if (BirthDate <= DateTime.Now)
            {
                Console.WriteLine($"Дата рождения: {BirthDate.ToLongDateString()}");
                Console.WriteLine($"Первое слово: {FirstWord}");
                Console.WriteLine($"Второе слово: {SecondWord}");
            }
            Console.WriteLine($"Вес: {Weight}");
            Console.WriteLine($"Рост: {Height}");
        }
    }
}
