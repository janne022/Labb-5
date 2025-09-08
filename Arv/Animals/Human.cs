using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public class Human : Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("tja");
        }
    }
}