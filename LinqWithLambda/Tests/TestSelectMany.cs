using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Tests
{
    public class TestSelectMany : ITest
    {
        public void Test()
        {
            var persons = new List<Person>();

            persons.Add(new Person
            {
                Id = 1,
                Name = "John",
                PersonPhones = new List<PersonPhone>() { new PersonPhone { PhoneNumber = "123456789" }, new PersonPhone { PhoneNumber = "987654321" } }
            });

            persons.Add(new Person
            {
                Id = 2,
                Name = "Mary",
                PersonPhones = new List<PersonPhone>() { new PersonPhone { PhoneNumber = "15697563" }, new PersonPhone { PhoneNumber = "951753" } }
            });

            var personPhones = persons.Select(person => person.PersonPhones);

            foreach (var personPhone in personPhones)
            {
                foreach (var phone in personPhone)
                {
                    Console.WriteLine(phone.PhoneNumber);
                }
            }

            Console.WriteLine();

            //Melhor para retorar uma lista dentro de outra lista
            var phones = persons.SelectMany(person => person.PersonPhones);

            foreach (var phone in phones)
            {
                Console.WriteLine(phone.PhoneNumber);
            }

        }

        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<PersonPhone> PersonPhones { get; set; }
        }

        class PersonPhone
        {
            public string PhoneNumber { get; set; }
        }
    }
}
