using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public class Bulldog(int age, int weight, int speed) : Dog(age, weight, speed)
    {
        readonly int strength;

        public void Guard()
        {
            System.Console.WriteLine($"Bites for {strength} damage!");
        }
    }
}