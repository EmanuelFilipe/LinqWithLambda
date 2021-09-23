using System;
using System.Linq;

namespace LinqWithLambda.Tests
{
    // retorna se todos os registros de uma lista correspondem a comparação que estamos fazendo ao filtro que estamos realizando
    public class TestAll : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustomers();

            // o All retorna um booleano
            var areAllCustomersWithIdGreaterThanZero = customers.All(customer => customer.Id >= 0);

            if (areAllCustomersWithIdGreaterThanZero)
                Console.WriteLine("All customers are with Id equal or greater than zero");
            else
                Console.WriteLine("All customers are not with Id equal or greater than zero");

            Console.WriteLine();

            var areAllCustomersWithAgeGreaterThanTwenty = customers.All(customer => customer.Age > 20);

            if (areAllCustomersWithAgeGreaterThanTwenty)
                Console.WriteLine("All customers are more than 20 years old");
            else
                Console.WriteLine("All customers are not more than 20 years old");

        }

    }
}
