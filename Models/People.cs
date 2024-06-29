using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemploop.Models
{
    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Greeting() {
            Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old.");
        }
    }
}