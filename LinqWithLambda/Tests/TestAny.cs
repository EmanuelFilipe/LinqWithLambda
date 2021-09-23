using System;
using System.Linq;

namespace LinqWithLambda.Tests
{
    public class TestAny : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();
            var orders = DataBase.DataBase.GetOrders();

            /* var bigOrders = orders.Where(o => o.TotalValue > 500000);

            if (bigOrders.Any())
                Console.WriteLine("we have big orders.");
            else
                Console.WriteLine("we don't have big orders.");
            */

            bool hasBigOrders = orders.Any(o => o.TotalValue > 500000);
            if (hasBigOrders)
                Console.WriteLine("we have big orders.");
            else
                Console.WriteLine("we don't have big orders.");

            Console.WriteLine();

            // retornando customer que tenha mais de 50 anos
            var oldCustomerOrders = orders.Where(order => customers.Any(customer => customer.Id == order.CustomerId && customer.Age > 50));

            foreach (var order in oldCustomerOrders)
                Console.WriteLine($"Customer Id: {order.CustomerId} - Purchased: {order.TotalValue.ToString("c2")}");

        }

    }
}
