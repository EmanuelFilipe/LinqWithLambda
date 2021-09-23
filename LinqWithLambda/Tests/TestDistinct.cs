using System;
using System.Linq;

namespace LinqWithLambda.Tests
{
    // retira dados duplicados de uma consulta
    public class TestDistinct : ITest
    {
        public void Test()
        {
            var orders = DataBase.DataBase.GetOrders();

            foreach (var order in orders)
                Console.WriteLine(order.CustomerId);

            Console.WriteLine();

            var customersIds = orders.Select(order => order.CustomerId).Distinct();
            foreach (var customerId in customersIds)
                Console.WriteLine(customerId);

        }

    }
}
