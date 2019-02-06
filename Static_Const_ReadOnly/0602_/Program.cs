using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0602_
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(Circle.GetAreaFormula());



            Console.WriteLine(Circle.pie);


            Circle.pie = 5.4;
            //Circle.UnchangablePie = 4.4;

            Circle c = new Circle(5.5);

            //c.RO_number = 4;

            Console.WriteLine( Circle.GetAreaFormula() );
            Console.WriteLine(Circle.pie);
            Console.WriteLine(BigCircle.pie);
            //Program p = new Program();
            //p.foo();
        }

        static void foo()
        {

        }

    }
}
