using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public class Chameleon : Animal
    {
        // Defines properties and constructor for Chameleon class
        public ConsoleColor Color { get; set; } = ConsoleColor.Green;
        public Chameleon(string name, int age, int weight, int speed) : base(name, age, weight, speed)
        {
            Species = "Chamaeleonidae";
            Diet = new Bugs().Name;
        }
        // Change 
        public void ChangeColor(ConsoleColor color)
        {
            Color = color;
            Console.Write($"{Name} slowly turns ");
            Console.ForegroundColor = Color;
            Console.WriteLine(Color.ToString());
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void MakeSound()
        {
            System.Console.WriteLine("hiss");
        }
    }
}