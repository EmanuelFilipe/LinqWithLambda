using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests
{
    public class TestTake : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            var firstTenCustomers = customers.Take(10);

            foreach (var customer in firstTenCustomers)
                Console.WriteLine($"Nome : {customer.Name}");


            var takeWhileCustomers = customers.TakeWhile(c => c.Age != 40);

            foreach (var customer in takeWhileCustomers)
                Console.WriteLine($"Nome : {customer.Name} || Age: {customer.Age}");

        }
    }
}
