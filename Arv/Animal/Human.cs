using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arv
{
    public class Human : Animal
    {
        // Defines properties and constructor
        public string[] Languages { get; set; } = ["English", "Swedish"];
        public Human(string name, int age, int weight, int speed) : base(name, age, weight, speed)
        {
            Species = "Homo sapiens";
            Diet = new CannedTuna().Name;
            Hunger = 40;
        }
        public override void MakeSound()
        {
            System.Console.WriteLine("tja");
        }
    }
}