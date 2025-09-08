using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public class Human : Animal
    {
        // Defines properties and constructor for Human class
        public override void MakeSound()
        {
            System.Console.WriteLine("tja");
        }
    }
}