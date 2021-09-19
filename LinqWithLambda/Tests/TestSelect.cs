using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests
{
    public class TestSelect : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            var firstQuery = from customer in customers
                             select customer.Name;
            
            // retornando mais de um parâmetro no select
            // pode nomear um nome de parâmetro
            var secondQuery = from customer in customers
                             select new { customer.Id, NameCustumer = customer.Name };

            /*foreach (var customer in secondQuery)
                Console.WriteLine(customer.NameCustumer);*/
            
            //--------------------------------------------------------------------------------------------------------

            var firstQueryWithLambda = customers.Select(customer => customer.Name);

            var secondQueryWithLambda = customers.Select(customer => new { customer.Id, NameCustomer = customer.Name });

            //foreach (var customer in secondQueryWithLambda)
            //    Console.WriteLine(customer.NameCustomer);

            var thirdQueryWithLambda = customers.Select(customer => new {
                Description = $"Customer Name :{customer.Name} Age: {customer.Age}"
            });

            foreach (var customer in thirdQueryWithLambda)
                Console.WriteLine(customer.Description);

            //--------------------------------------------------------------------------------------------------------


        }
    }
}
