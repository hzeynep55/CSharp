using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database database=new Database();
            //AbstractClasses classlar new lenemezler
            Database database = new Oracle();
            database.Add();
            database.Remove();

            Database database2 = new SqlServer();
            database2.Add();
            database2.Remove();
        }
    }
    abstract class Database //ABSTRACTLAR INHERİTANCEDİR
    {
        public void Add() //tamamlanmış metot
        {
            Console.WriteLine("Deleted by default");

        }

        public abstract void Remove(); //tamamlanmamış metot. abstract içi dolu almayan virtual metot
    }
    class SqlServer : Database
    {
        public override void Remove() //Sadece remove geldi
        {
            Console.WriteLine("Deleted by defaultSql");
        }
    }

    class Oracle : Database
    {
        public override void Remove()
        {
            Console.WriteLine("Deleted by defaultOracle"); //remove her classta farklı farklı olmaktadır.
        }
    }
}
