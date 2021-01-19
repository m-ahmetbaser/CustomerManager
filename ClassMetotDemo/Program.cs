using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();
            customer1.name = "Ahmet";
            customer1.Age = 20;
            customer1.Id = "3604531";
            customer2.name = "Hakan";
            customer2.Age = 24;
            customer2.Id = "1569532";
            customer3.name = "Savas";
            customer3.Age = 37;
            customer3.Id = "7216598";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };



            foreach (var item in customers)
            {
                Console.WriteLine(item.name+"");
                Console.WriteLine(item.Age+"");
                Console.WriteLine(item.Id + "\n");


            }

            Console.WriteLine("\n");

            CustomerManager customerMan = new CustomerManager();
            customerMan.Add(customer1.name, customer1.Id, customer1.Age);
            customerMan.Delete(customer2.name, customer2.Id, customer2.Age);

            
        }
    }
}
