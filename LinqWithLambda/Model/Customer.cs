using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLambda.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int SecondAge
        {
            get
            {
                Console.WriteLine("i am this " + Name);
                return Age;
            }
        }
    }
}
