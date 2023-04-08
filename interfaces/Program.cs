using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo();
            //InterfacesIntro();
            ICustomerDal[] customerDals= new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
            };
            foreach(var customer in customerDals)
            {
                customer.Add();
            }
            IPerson person = new Customer();
            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManeger customer = new CustomerManeger();
            customer.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Zeynep",
                LastName = "Durhat",
                Address = "İstanbul"
            };
            Student student = new Student
            {
                Id = 1,
                FirstName = "Zeynep",
                LastName = "Durhat",
                Department = "Computer Programming"
            };

            personManager.Add(customer);
            personManager.Add(student);
        }


        interface IPerson
        {
             int Id { get; set; }
            string FirstName { get; set; }
           string LastName { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get ; set; }
            public string LastName { get ; set ; }
            public string Address { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set ; }
            public string FirstName { get ; set ; }
            public string LastName { get ; set ; }
            public string Department { get; set; }
        }

        class Worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
               
            }
        }
    }
}
