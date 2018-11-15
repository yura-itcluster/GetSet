using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class Person
    {
        private int age;

        public int Age
        {
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть больше 17");
                }
                else
                {
                    age = value;
                }
            }
            get { return age; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 6;
            Console.WriteLine(person.Age);
            Console.ReadKey();
        }
    }
}
