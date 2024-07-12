using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemploop.Models
{
    public class Current : Account
    {
        public override void deposit(decimal value)
        {
            balance += value;
        }
    }
}