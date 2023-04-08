using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            int num = 20;
            num = number;
            number = 30;
            Console.WriteLine(num);

            string[] cities = new[] {"İstanbul","Ankara","İzmir","Samsun" };

            string[] cities2 = new[] { "Trabzon", "Bolu", "Yalova", "Sinop" };

            cities2 = cities;

            cities[2] = "Karabük";
            Console.WriteLine(cities2[2]);

            foreach(string value in cities)
            {
                Console.WriteLine(value);
            }

            DataTable dataTable;
            DataTable dataTable1= new DataTable();
            dataTable = dataTable1;
            Console.ReadLine();
        }
    }
}
