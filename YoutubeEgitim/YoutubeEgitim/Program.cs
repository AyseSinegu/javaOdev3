using System;

namespace YoutubeEgitim
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int sayi1 = 10;
            //  int sayi2 = 20;
            //  sayi1 = sayi2;
            //  sayi2 = 100;
            //int[] sayilar1 = new[] { 1, 2, 3 };
            //int[] sayilar2 = new[] { 10, 20, 30 };
            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;
            //Console.WriteLine(sayilar1[0]);

            //CreditManager creditManager = new CreditManager();
            //creditManager.Calculate();
            //creditManager.Save();

            //Customer customer = new Customer();
            //customer.id = 1;
            //customer.City = "Ankara";

            //CustomerManager customerManager = new CustomerManager(customer);
            //customerManager.Save();
            //customerManager.Delete();

            //Company company = new Company();
            //company.TaxNumber = "1000";
            //company.CompanyName = "Arçelik";
            //company.id = 100;

            //CustomerManager customerManager2 = new CustomerManager(new Person());

            //Person person = new Person();
            //person.FirstName = "Engin";
            //person.NationalIdendity = "123456";

            //Customer c1 = new Customer();
            //Customer c2 = new Person();
            //Customer c3 = new Company();

            CustomerManager customerManager = new CustomerManager(new Customer(), new TeacherCreditManager());
            customerManager.GiveCredit();

            Console.ReadLine();

        }
    }
    class CreditManager
    {
    public void Calculate(int creditType)
    {
       if (creditType==1) //esnaf
            {

            }
       if(creditType==2)//ogretmen
            {

            }
            Console.WriteLine("Hesaplandı");
    }
    public void Save()
    {
            Console.WriteLine("Kredi verildi");
    }

      }
    interface ICreditManager
    {
        void Calculate();
        void Save();
    }
    abstract class BaseCreditManager : ICreditManager
    {
        public abstract void Calculate(); //ortak
       

        public virtual void Save()
        {
            Console.WriteLine("Kaydedildi");
        }
    }
    class TeacherCreditManager :BaseCreditManager, ICreditManager
    {
        public override void Calculate() //ortak değil
        {
            Console.WriteLine("Öğretmen kredisi hesaplandı");
        }
        public override void Save()
        {
            base.Save();
        }

    }
    class MilitaryCreditManager :BaseCreditManager, ICreditManager
    {
        public override void  Calculate()
        {
            Console.WriteLine("Asker kredisi hesaplandı");
        }

       
    }
    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Müşteri nesnesi başlatıldı");
        }
        public int id { get; set; }
       
        public string City { get; set; }
    }
    class Person : Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdendity { get; set; }
    }

    class Company : Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
    class CustomerManager
    {
        private Customer _customer;
        private ICreditManager _creditManager;
        private ICreditManager creditManager;
        public CustomerManager(Customer customer, ICreditManager creditManager)
        {
            _customer = customer;
            _creditManager = creditManager;
        }

        public void Save()
        {
            Console.WriteLine("Müşteri kaydedildi:" );
        }
        public void Delete()
        {
            Console.WriteLine("Müşteri silindi:" );
        }
        public void GiveCredit()
        {
            _creditManager.Calculate();
            Console.WriteLine("Kredi verildi");
        }
    }
}
