using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public class Bulldog : Dog
    {
        int strength;
        public Bulldog(int age, int weight, string species, string diet, int speed)
        : base(age, weight, species, diet, speed)
        {

        }
        public void Guard()
        {
            System.Console.WriteLine($"Bites for {strength} damage!");
        }
    }
}