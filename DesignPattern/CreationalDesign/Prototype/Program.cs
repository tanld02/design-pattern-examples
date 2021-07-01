using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Euro", 2020);
            Console.WriteLine("Main person: ");
            person.Introduce();
            var personCopy = (Person)person.Clone();
            Console.WriteLine("Copy person: ");
            personCopy.Introduce();
        }
    }
}
