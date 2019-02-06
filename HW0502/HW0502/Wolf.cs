using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0502
{
    class Wolf : Dog
    {
        public string nameOfPack;

        public Wolf(string name, string favoriteFood, string nameOfPack) : base(name, favoriteFood)
        {
            this.nameOfPack = nameOfPack;
        }

        public override string ToString()
        {
            return $"WOLF : pack : {this.nameOfPack} {base.ToString()}";
        }
    }
}
