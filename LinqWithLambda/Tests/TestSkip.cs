using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests
{
    public class TestSkip : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            var skipCustomers = customers.Skip(10);

            foreach (var customer in skipCustomers)
                Console.WriteLine($"Nome : {customer.Name}");

            Console.WriteLine();

            var skipWhileCustomers = customers.SkipWhile(c => c.Age != 40);

            foreach (var customer in skipWhileCustomers)
                Console.WriteLine($"Nome : {customer.Name} || Age: {customer.Age}");


        }
    }
}
