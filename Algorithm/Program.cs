
using Algorithm;
using System.Numerics;

namespace ToTypeExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            DateTime date = DateTime.Now;
            //object obj = new();
            var obj = random.Next(23,56);
            int num = 56;
            
           

            Console.WriteLine(date.ToDateTime());
            Console.WriteLine(obj.ToDecimal());
            
            Console.WriteLine(obj.ToInt());
            Console.WriteLine(num.IsNegativeNumber());
           



        }
    }
}
          