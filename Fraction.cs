using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lab3
{
    class Fraction
    {
        int numerator;
        int denomirator;

        public int Numerator { get => numerator; set => numerator = value; }
        public int Denomirator { get => denomirator; set => denomirator = (value != 0 ? value : 1); }

        public Fraction()
        {
            this.denomirator = 1;
        }

        public Fraction(int numerator)
        {
            this.numerator = numerator;
            this.denomirator = 1;
        }

        public Fraction(int numerator, int denomirator) : this(numerator)
        {
            Denomirator = denomirator;
        }

        override public String ToString()
        {
            return " " + this.numerator + "\n-----\n" + " " + this.denomirator; 
        }

        public void Reverse()
        {
            int numerator = this.numerator;
            this.numerator = this.denomirator;
            this.denomirator = numerator;
        }

        public void Add(Fraction fraction)
        {
            if (this.denomirator == fraction.denomirator)
            {
                this.numerator += fraction.numerator;
                return;
            }
            int commonDenominator = this.denomirator * fraction.denomirator;
            int commonNumerator = this.numerator * fraction.denomirator + fraction.numerator * this.denomirator;

            this.numerator = commonNumerator;
            this.denomirator = commonDenominator;
        }

        public void Diff(Fraction fraction)
        {
            if (this.denomirator == fraction.denomirator)
            {
                this.numerator -= fraction.numerator;
                return;
            }

            int commonDenominator = this.denomirator * fraction.denomirator;
            int commonNumerator = this.numerator * fraction.denomirator - fraction.numerator * this.denomirator;

            this.numerator = commonNumerator;
            this.denomirator = commonDenominator;
        }

        public void Mult(Fraction fraction)
        {
            this.numerator *= fraction.numerator;
            this.denomirator *= fraction.denomirator;
        }

        public void Division(Fraction fraction)
        {
            fraction.Reverse();
            this.numerator *= fraction.numerator;
            this.denomirator *= fraction.denomirator;
        }

        public void Simplify()
        {
            int tNumerator = this.numerator;
            int tDenominator = this.denomirator;

            if (tDenominator % tNumerator == 0)
            {
                denomirator /= numerator;
                numerator = 1;
                return;
            }

            for (int i = 2; i < tNumerator; i++)
            {
                if (tNumerator % i == 0 && tDenominator % i == 0)
                {
                    tNumerator /= i;
                    tDenominator /= i;
                    i--;
                }
            }

            this.numerator = tNumerator;
            this.denomirator = tDenominator;
        }
    }
}
