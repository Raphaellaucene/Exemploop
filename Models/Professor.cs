using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemploop.Models
{
    public class Professor : Person
    {
        public decimal Salary { get; set; }

        public override void Greeting()
        {
            Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old. My salary is " + Salary);
        }
    }
}