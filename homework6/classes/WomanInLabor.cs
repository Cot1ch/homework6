using System;
using System.Collections.Generic;

namespace homework6
{
    internal class WomanInLabor : Person
    {
        private byte _ChildrenCount;
        private Dictionary<Guid, Child> _Children;

        public WomanInLabor(string name, string lastname, byte childcount)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.ChildrenCount = childcount;
            this.Children = new Dictionary<Guid, Child>();
        }

        public byte ChildrenCount
        {
            get { return _ChildrenCount; }
            set { _ChildrenCount = value; }
        }

        public Dictionary<Guid, Child> Children
        {
            get { return _Children; }
            set { _Children = value; }
        }

        public void AddChild(Dictionary<Guid, Child> childs, Child child)
        {
            childs.Add(Guid.NewGuid(), child);
        }


        public override void ShowInfo()
        {
            Console.WriteLine($"\n{Name} {Lastname}");
            Console.WriteLine($"Возраст: {GetAge(BirthDate)}");
            Console.WriteLine($"Паспорт: {PassportSeria} {PassportNumber.ToString("D6")}");
            Console.WriteLine($"\nДети:");
            foreach (var child in Children.Keys)
            {
                Children[child].ShowInfo();
            }
        }
    }
}
