using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0502
{
    class Horse : Animal
    {
        public bool isRacingHorse;
        public Horse(string name, bool isRacingHorse) : base(name)
        {
            this.isRacingHorse = isRacingHorse;
        }

        public override void MakeSound()
        {
            this.Neigh();
        }

        public virtual void Neigh()
        {
            Console.WriteLine("ieeehhhhh");
        }

        public override string ToString()
        {
            // return $"Horse {(racingHorse  == true? "Racing horse" : "non racing horse")}";
            return $"Horse {(isRacingHorse ? "Racing horse" : "not racing horse")} {base.ToString()}";
        }
    }
}
