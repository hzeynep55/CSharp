using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
     class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] students = new string[3] { "Hanne", "Zeynep", "Saliha" };
                students[3] = "Berra";// burada bir hata olduğunda catch e geçiyor.
            }
            catch (IndexOutOfRangeException exception) // yukarıdaki hatanın türü IndexOutOfRangeException
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception){ //hata exception a ekleniyor, tüm exception türleri burdan türer

                Console.WriteLine(exception.Message);
            }
           


            Console.ReadLine();
        }
    }
}
