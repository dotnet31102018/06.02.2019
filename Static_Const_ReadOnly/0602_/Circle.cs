using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0602_
{
    class Circle
    {
        public static double pie = 3.14;
        public const double UnchangablePie = 3.14159268;
        public double radius;

        public const int size = 10;
        public static int sizeStatic = 10;

        public int sizeRegular = 10;

        public int[] arr1 = new int[10]; // regular number
        public int[] arr2 = new int[size]; // const
        public int[] arr3 = new int[sizeStatic]; // static 
        //public int[] arr4 = new int[sizeRegular]; // data

        public readonly int RO_number;

        public Circle(double radius)
        {
            RO_number = 3;
            this.radius = radius;
        }

        public double GetArea()
        {
           
            int[] arr4 = new int[sizeRegular];
            return pie * radius * radius;
        }

        public static string GetAreaFormula()
        {

            
            Console.WriteLine(UnchangablePie);
            Circle c = new Circle(3);
            //return $"{radius } * {radius } * {pie}";
            return "Pie * Radius * Radius";
        }
    }
}
