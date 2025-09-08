using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public class Retriever(int age, int weight, int speed) : Dog(age, weight, speed)
    {
        private string retrievedItem = "";
        public void Retrieve(string item)
        {
            retrievedItem = item;
            System.Console.WriteLine($"Fetched {item}!");
        }
        public void Drop()
        {
            System.Console.WriteLine($"Dropped {retrievedItem}!");
            retrievedItem = "";
        }
    }
}