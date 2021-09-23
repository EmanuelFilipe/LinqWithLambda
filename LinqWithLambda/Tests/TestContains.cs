using System;
using System.Linq;

namespace LinqWithLambda.Tests
{
    public class TestContains : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            var customersId = customers.Select(customer => customer.Id);

            if (customersId.Contains(1))
                Console.WriteLine("there is a customer with id - 1");
            else
                Console.WriteLine("there is not a customer with id - 1");

            Console.WriteLine();

            var customersName = customers.Select(customer => customer.Name);

            if (customersName.Contains("Customer 0"))
                Console.WriteLine("there is a customer with name like customer 0");
            else
                Console.WriteLine("there is not a customer with name like customer 0");

        }

    }
}
