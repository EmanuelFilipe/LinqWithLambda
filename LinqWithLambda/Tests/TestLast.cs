using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests
{
    public class TestLast : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            var lastCustomer = customers.Last();
            Console.WriteLine($"Nome : {lastCustomer.Name} || Age: {lastCustomer.Age}");

            try
            {
                var errorCustomer = customers.Last(c => c.Id < 0);
                Console.WriteLine($"Nome : {errorCustomer.Name} || Age: {errorCustomer.Age}");
            }
            catch (Exception e)
            {
                Console.WriteLine("ther is no customer with this condition. Details: " + e.ToString());
            }

            var errorCustomerLoD = customers.LastOrDefault(c => c.Id < 0);

            if (errorCustomerLoD == null)
                Console.WriteLine("The is no customer");

            var customerWithAge = customers.LastOrDefault(c => c.Age < 40);
            Console.WriteLine($"Nome : {customerWithAge.Name} || Age: {customerWithAge.Age}");
        }
    }
}
