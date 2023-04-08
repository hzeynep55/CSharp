using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
   class Program
   {
        static void Main(string[] args)
        {

            Product product = new Product { Id = 1, Name = "Zeynep" };
            Product product1 = new Product(1, "Hanne");
            CustomerManager customManager = new CustomerManager();

            customManager.List();
            Console.WriteLine(product.Id + " " + product.Name);


            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());// constructor sayesinde böyle yazdık
            employeeManager.Add();
        

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            //Teacher teacher=new Teacher //static olduğundan dolayı new lenemiyor.
            Teacher.Number = 10;
            Utilities.Validate();

            Manager.DoSomething();
            Manager manager= new Manager();
            manager.DoSomething2();

            Console.ReadLine();
        }
   }

    class CustomerManager
    {
        private int _count=14; //private field alt çizgi ile başlatılır
        public CustomerManager(int count) //Bir sınıfın ihtiyaç duyduğu farklı parametreler varsa, ve bunlar kuulanıma göre değişiklik gösteriyorsa constructor dan faydalanırız
        { 
                _count=count;  //ihtiyaç duyulan parametreler set edilir
        }

        //overloding
        public CustomerManager()
        {

        }
        public void List() {

            Console.WriteLine("Listed {0} items",_count);

        }

        public void Add() {

            Console.WriteLine("Added");
        }
    }

    class Product
    {
        public Product()  //değerlerihılıca set etmek için böş bir constructor tanımlanır.
        {

        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id=id;
            _name=name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("logged to file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger= logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }

    //base sınıfa parametre gönderme
    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity=entity;
        }
        public void Message() {


            Console.WriteLine("{0} message", _entity);
        }
    }
    class PersonManager : BaseClass
    {
            //base değer gönderiyorum
        public PersonManager(string entity) : base(entity)
        {
        }
        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }
    static class Teacher //bir nesnenin asla instance sı oluşturulamaz
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        static Utilities()
        {

        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine(" done");
        }

        public void DoSomething2() 
        { 
            Console.WriteLine("done 2");
        
        }
    }
}
