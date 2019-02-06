using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0502
{
    class Poodle : Dog
    {
        public int numberOfPonyTails;

        public Poodle(string name, string favoriteFood, int numberOfPonyTails) : base(name, favoriteFood)
        {
            this.numberOfPonyTails = numberOfPonyTails;
        }

        public override void Bark()
        {
            Console.WriteLine("hmmm hmmm");
        }

        public override string ToString()
        {
            return $"Poodle Pony tails : {this.numberOfPonyTails}  {base.ToString()}";
        }
    }
}
