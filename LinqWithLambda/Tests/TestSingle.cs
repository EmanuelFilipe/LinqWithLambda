using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests
{
    public class TestSingle : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            var customerWithAge = customers.Single(c => c.Age == 19);
            Console.WriteLine($"Nome : {customerWithAge.Name} || Age: {customerWithAge.Age}");


            var customerWithAgeSoD = customers.SingleOrDefault(c => c.Age == 10);
            if (customerWithAgeSoD != null)
                Console.WriteLine($"Nome : {customerWithAgeSoD.Name} || Age: {customerWithAgeSoD.Age}");
            else
                Console.WriteLine("ther is no customer with this condition.");

            // FIRST é o mais performatico
            var customerWithFirst = customers.First(c => c.SecondAge == 19);
            var customerWithSingle = customers.Single(c => c.SecondAge == 19);
           
        }
    }
}
