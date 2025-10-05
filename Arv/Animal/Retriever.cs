using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public class Retriever(string name, int age, int weight, int speed) : Dog(name, age, weight, speed)
    {
        public string RetrievedItem { get; private set; } = "";
        public void Retrieve(string item)
        {
            RetrievedItem = item;
            System.Console.WriteLine($"Fetched {item}!");
        }
        public void Drop()
        {
            System.Console.WriteLine($"Dropped {RetrievedItem}!");
            RetrievedItem = "";
        }
    }
}