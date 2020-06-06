using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------
            Console.WriteLine("Add:");
            Fraction drob1 = new Fraction(3);
            Console.WriteLine(drob1 + "\n +");
            Fraction drob2 = new Fraction(4, 2);
            Console.WriteLine(drob2 + "\n =");
            drob1.Add(drob2);
            Console.WriteLine(drob1);
            Console.WriteLine();
            //----------------------------------
            Console.WriteLine("Diff:");
            Fraction drob3 = new Fraction(15, 10);
            Console.WriteLine(drob3 + "\n -");
            Fraction drob4 = new Fraction(23, 12);
            Console.WriteLine(drob4 + "\n =");
            drob3.Diff(drob4);
            Console.WriteLine(drob3);
            Console.WriteLine();
            //----------------------------------
            Console.WriteLine("Mult:");
            Fraction drob5 = new Fraction(2, 5);
            Console.WriteLine(drob5 + "\n *");
            Fraction drob6 = new Fraction(14, 9);
            Console.WriteLine(drob6 + "\n =");
            drob5.Mult(drob6);
            Console.WriteLine(drob5);
            Console.WriteLine();
            //----------------------------------
            Console.WriteLine("Division:");
            Fraction drob7 = new Fraction(6, 7);
            Console.WriteLine(drob7 + "\n /");
            Fraction drob8 = new Fraction(14, 8);
            Console.WriteLine(drob8 + "\n =");
            drob7.Division(drob8);
            Console.WriteLine(drob7);
            Console.WriteLine();
            //----------------------------------
            Console.WriteLine("Simplify:");
            Fraction drob9 = new Fraction(99, 120);
            Console.WriteLine(drob9 + " =");
            drob9.Simplify();
            Console.WriteLine(drob9);
            //----------------------------------

        }
    }
}
