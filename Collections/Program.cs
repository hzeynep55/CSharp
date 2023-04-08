using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] cities = new string[2] {"Ankara","İstanbul" };
            cities = new string[3]; //arrayin boyutunu büyülttük.
            Console.WriteLine(cities[0]); //boş döner çünk, yeni referams ile bilgiler uçtu. boş çünkü değer atamadık*/

            /*Arrays arrays=new Arrays();
            arrays.Arraylist();*/

            List<string> cities = new List<string>(); //string değerler eklenebilir.
            cities.Add("Ankara");
            cities.Add("İstanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            //1.Yol

            Console.WriteLine(cities.Contains("Ankara"));//aradağımız değerde eleman var mı diye arama yapar.0
            Console.WriteLine("------------------------");

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, Name = "Zeynep" });

            customers.Add(new Customer { Id = 2, Name = "Hanne" });


            //2.Yol
            /*List<Customer> customers1 = new List<Customer>
            {
                 new Customer  { Id = 3, Name = "Berra" },

                 new Customer { Id = 4, Name = "Saliha" }
             };*/


            var customer1 = new Customer
            {
                Id = 3,
                Name = "Ayşe"
            };
            customers.Add(customer1);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id=4, Name="Fatma"},
                new Customer{ Id=5, Name="Zehra"}
            }); //array vererek ekleme yapabiliriz

            //customers.Clear();//liatedeki tüm elemanları siler.
            Console.WriteLine(customers.Contains(customer1)); //customers içinde customer1(referans tutuyor) değeri var mı diye bakar

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + " " + customer.Name);
            }

            /* foreach (var customer in customers1)
             {
                 Console.WriteLine(customer.Id + " " + customer.Name);
             }*/

            var count = customers.Count;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Eleman sayısı: " + count);

            Console.ReadLine();
        }


        class Arrays
        {

            public void Arraylist()
            {
                ArrayList cities = new ArrayList();
                cities.Add("Ankara");
                cities.Add("İstanbul");

                cities.Add("Samsun");
                cities.Add(1);
                cities.Add("Bursa");
                //Console.WriteLine(cities[2]);

                foreach (var i in cities)
                {
                    Console.WriteLine(i);
                }

            }



        }
        class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
