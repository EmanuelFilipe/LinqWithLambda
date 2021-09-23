using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests
{
    public class TestWhere : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();
            var orders = DataBase.DataBase.GetOrders();

            var ageCustomers = customers.Where(c => c.Age > 40 && c.Age < 51);

            foreach (var customer in ageCustomers)
            {
                Console.WriteLine($"Nome : {customer.Name} || Age: {customer.Age}");
            }

            Console.WriteLine();

            //var firstCustomerOrder = orders.Where(o => o.CustomerId == 1 && o.TotalValue > 1000 && o.TotalValue < 3000 || o.CustomerId == 2);
            var firstCustomerOrder = orders.Where(order => ValidateOrders(order));

            foreach (var order in firstCustomerOrder)
            {
                Console.WriteLine($"Id : {order.CustomerId} || purchased: {order.TotalValue.ToString("c2")}");
            }

        }

        private bool ValidateOrders(Model.Order order)
        {
            return (order.CustomerId == 1 && order.TotalValue > 1000 && order.TotalValue < 3000) || (order.CustomerId == 2);
        }
    }
}
