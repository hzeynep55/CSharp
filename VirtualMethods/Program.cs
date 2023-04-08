using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            MySql mySql=new MySql();

            sqlServer.Add();
            mySql.Add();

            Console.ReadLine();
        }
      
    }
    class Database
    {
        public virtual void Add() {


            Console.WriteLine("Added by default");
        }
        public virtual void Delete() { //virtual a sahip metotlar en üstte gelir

            Console.WriteLine("Deleted by default");
        }

       
    }
    class SqlServer :Database //kalıtım(inhehirance)
    {
        public override void Add()
        {
            Console.WriteLine("Added by SqlServer");
            base.Add(); //babası database. buna base denir
        }
    }

    class MySql : Database 
    { 
    
    }
}
