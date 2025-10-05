using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public class Bulldog(string name, int age, int weight, int speed) : Dog(name, age, weight, speed)
    {
        // Declare field
        private int _strength = 8;

        // Method for printing the damage of a Bulldog
        public void Guard()
        {
            System.Console.WriteLine($"Bites for {_strength} damage!");
        }
    }
}