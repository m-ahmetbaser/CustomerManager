using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
       public void Add(string name,string id , int age)
        {
            Console.WriteLine(name + " isimli " + age.ToString() + " yasinda " + id + " kimlikli müsteri kaydi yapilmistir");
        }
        public void Listing(string name, string id, int age)
        {
            Console.WriteLine(name + id + age.ToString());
           
        
        }
        public void Delete(string name, string id, int age)
        {
            Console.WriteLine(name + " isimli " + age.ToString() + " yasinda " + id + " kimlikli müsteri kaydi silinmistir");
        }
    }
}
