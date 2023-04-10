using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lİst();
            //ArrayList();
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add("book", "kitap");
            dic.Add("notebook", "defter");
            dic.Add("chair", "sandalye");

            Console.WriteLine(dic["notebook"]); //defter değerini verir.key ve value ye de ayrı ayrı ulaşabiliriz.

            foreach(var item in dic)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(dic.ContainsKey("Glass"));
            Console.WriteLine(dic.ContainsValue("Bilgisayar"));


            Console.ReadLine();
        }

        private static void Lİst()
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


            customers.Insert(0, customer1);//0.indekse customer 1'ekledim
            customers.Remove(customer1); //buduğu ilk değeri siler
            customers.RemoveAll(x => x.Name == "Ayşe");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + " " + customer.Name);
            }

            /* foreach (var customer in customers1)
             {
                 Console.WriteLine(customer.Id + " " + customer.Name);
             }*/

            var count = customers.Count;
            Console.WriteLine("Eleman sayısı: " + count);
            Console.WriteLine("----------------------------");

            var index = customers.IndexOf(customer1);
            Console.WriteLine("Index: {0}", index);

            customers.Add(customer1);
            var index1 = customers.LastIndexOf(customer1);//aramaya sondan başlayacak
            Console.WriteLine("Index: {0}", index1);
        }
        public static void ArrayList()
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

        class Arrays
        {

            public void Arraylist()
            {
                
            }



        }
        class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
