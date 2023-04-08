using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager=new CustomerManager();
            customerManager.Loger = new DatabaseLogger();
            customerManager.Add();
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public ILogger Loger { get; set; }
        public void Add()
        {

            Loger.Log();
            Console.WriteLine("Customer Added");
        }
    }
    class DatabaseLogger:ILogger
    {
        public void Log() //loglamaişleminde bir bese i olmalı
        { 
            Console.WriteLine("Logged!");
        }

    }
    interface ILogger
    {
        void Log();
    }
}
