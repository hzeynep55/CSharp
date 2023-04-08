using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     class Program
     {
        static void Main(string[] args)
        {
            Person[] person = new Person[3]
            {
               new Person{FirstName="Berra"},new Student{FirstName="Hanne"},new Customer{FirstName="Zeynep"}
            };
            foreach(var persons in person)
            {
                Console.WriteLine(persons.FirstName);
            }
            Console.ReadLine();
        }
     }
    class Person 
    { 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
    }

    class Customer : Person { // bir classa tek bir classtan kalıtım yapılabiir.
        public string City{ get; set; }
    }
    class Student:Person {

        public string Department { get; set; }
    }
}
