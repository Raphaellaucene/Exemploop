using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemploop.Models
{
    public class Student : Person
    {
        //constructor passing name to parent class
        public Student(string name) : base(name)
        {
        }
        public double Grade { get; set; }

        public override void Greeting()
        {
            Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old. My grade is " + Grade);
        }
    }
}