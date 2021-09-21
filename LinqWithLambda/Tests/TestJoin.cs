using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests
{
    public class TestJoin : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();
            var orders = DataBase.DataBase.GetOrders();

            /*var customersOrders = customers.Join(
                orders,
                customer => customer.Id,
                order => order.CustomerId,
                //(customer, order) => new { Customer = customer, Order = order }
                (customer, order) => new { Name = customer.Name, TotalValue = order.TotalValue, CreatedDate = order.CreateDate }
            );

            foreach (var customerOrder in customersOrders)
            {
                Console.WriteLine($"The customer: {customerOrder.Name} || purchased: {customerOrder.TotalValue.ToString("c2")}" +
                    $" in {customerOrder.CreatedDate.ToString("dd/MM/yyyy")}");
            }
            */


            var customersOrders = customers.GroupJoin(
                orders,
                customer => customer.Id,
                order => order.CustomerId,
                (customer, allOrders) => new { Customer = customer, AllOrders = allOrders }
            );

            foreach (var customerOrder in customersOrders)
            {
                Console.WriteLine($"The customer: {customerOrder.Customer.Name} || purchased: ");

                foreach (var order in customerOrder.AllOrders)
                {
                    Console.WriteLine($"Total Value: {order.TotalValue.ToString("c2")} in " +
                        $"{order.CreateDate.ToString("dd/MM/yyyy")}");
                }
                Console.WriteLine();
            }
        }
    }
}
