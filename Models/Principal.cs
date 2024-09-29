using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemploop.Models
{
    public class Principal : Professor
    {
        public override void Greeting()
        {
            Console.WriteLine("Hello, I am the principal of this school.");
        }
    }
}