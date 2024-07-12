using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemploop.Models
{
    public class Person
    {
        //constructor requiring name
        public Person(string name) {
            Name = name;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Greeting() {//change to virtual to allow override by child classes
            Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old.");
        }
    }
}