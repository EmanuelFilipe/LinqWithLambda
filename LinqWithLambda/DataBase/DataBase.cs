using LinqWithLambda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.DataBase
{
    public static class DataBase
    {
        public static List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();

            for (int index = 0; index <= 50; index++)
            {
                var customer = new Customer
                {
                    Id = index,
                    Name = $"Customer {index}",
                    Age = 19 + index
                };

                customers.Add(customer);
            }

            return customers;
        }

        public static List<Order> GetOrders()
        {
            var orders = new List<Order>();
            var customerId = 0;

            for (int index = 0; index <= 1000; index++)
            {
                var customer = new Order
                {
                    Id = index,
                   // if (customerId > 50) customerId = 0;
                    CustomerId = (customerId > 50 ? customerId = 0 : customerId),
                    CreateDate = DateTime.Now,
                    TotalValue = 10 * index
                };

                orders.Add(customer);
            }

            return orders;
        }
    }
}
