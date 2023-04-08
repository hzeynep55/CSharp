using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        private int id { get; set; }//private sadece tanımlandığı blokta kullanılabilir.
        protected int Customer_id; //protected private'nin tüm özelliklerini kapsar. 
        public void Save()
        { 
             id= 1; //eğer id yi burada tanımlasaydım başka br metotta ya da metot dışında kullanmam
        }
    }

    class Student :Customer
    {
         public void Save2() 
         { 
           
              Customer_id= 1;// protected inhetitance sınıflarda ullanabiliyoruz.ile customer_id burada geldi.
         }
    }

    public class Course //internal class assembly içerisinde referans olmadan kullanabiliyoruz.
    {
        public string Name { get; set; }
    }
}
