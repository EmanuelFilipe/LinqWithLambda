using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests
{
    public class TestFirst : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            // FIRST 

            var firstCustomer = customers.First();
            //Console.WriteLine(firstCustomer.Name);

            var firstCustomerAge = customers.First(c => c.Age > 30);
            //Console.WriteLine($"Nome : {firstCustomerAge.Name} || Age: {firstCustomerAge.Age}");

            try
            {
                var customerWithAgeLessThen = customers.First(c => c.Age < 10);
                Console.WriteLine($"Nome : {customerWithAgeLessThen.Name} || Age: {customerWithAgeLessThen.Age}");
            }
            catch (Exception e)
            {
                //Console.WriteLine("ther is no customer with this condition. Details: " + e.ToString());
            }

            Console.WriteLine();

            // FIRSTORDEFAULT

            var firstCustomerFoD = customers.FirstOrDefault();
            //Console.WriteLine(firstCustomerFoD.Name);
            
            var firstCustomerAgeFoD = customers.FirstOrDefault(c => c.Age > 30);
            //Console.WriteLine($"Nome : {firstCustomerAgeFoD.Name} || Age: {firstCustomerAgeFoD.Age}");

            var customerWithAgeLessThenFoD = customers.FirstOrDefault(c => c.Age < 10);

            if (customerWithAgeLessThenFoD != null)
                Console.WriteLine($"Nome : {customerWithAgeLessThenFoD.Name} || Age: {customerWithAgeLessThenFoD.Age}");
            else
                Console.WriteLine("ther is no customer with this condition.");


            var firstAge = customers.Select(c => c.Age).FirstOrDefault(age => age < 10);
            Console.WriteLine(firstAge);
        }
    }
}
