using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Person : ICloneable
    {
        private readonly string _name;
        private readonly int _age;
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public void Introduce()
        {
            Console.WriteLine($"Hello my name is: {_name}, Age: {_age}");
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
