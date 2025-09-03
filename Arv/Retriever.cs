using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public class Retriever : Dog
    {
        string retrievedItem = "";
        public Retriever(int age, int weight, string species, string diet, int speed)
        : base(age, weight, species, diet, speed)
        {

        }
    }
}