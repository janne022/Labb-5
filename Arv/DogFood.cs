using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public class DogFood : Food
    {
        public DogFood()
        {
            _name = "Dog Food";
            _saturation = 10;
        }
    }
}