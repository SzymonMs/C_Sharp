using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy
{
    internal class ComplexNumber
    {
        public double a;
        public double b;
        public void PrintCmplx(int n = 10)
        {
            this.a = Math.Round(this.a, n);
            this.b = Math.Round(this.b, n);
            if (this.b > 0 && this.a != 0)
                Console.WriteLine("{0}+j{1}", this.a, this.b);
            else if (this.b < 0 && this.a != 0)
                Console.WriteLine("{0}-j{1}", this.a, Math.Abs(this.b));
            else if (this.b == 0 && this.a != 0)
                Console.WriteLine("{0}", this.a);
            else if (this.b > 0 && this.a == 0)
                Console.WriteLine("j{0}", this.b);
            else if (this.b < 0 && this.a == 0)
                Console.WriteLine("-j{0}", Math.Abs(this.b));
            else
                Console.WriteLine(0);
        }
        public ComplexNumber()
        {
            a = 0;
            b = 0;
        }
        public ComplexNumber(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.a + c2.a, c1.b + c2.b);
        }
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.a - c2.a, c1.b - c2.b);
        }
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.a * c2.a - c2.b * c1.b, c1.a * c2.b - c2.a * c1.b);
        }
        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            if ( c2.a == 0 && c2.b == 0)
            {
                throw new Exception("Dzielisz przez 0");
            }
            return new ComplexNumber((c1.a * c2.a + c1.b * c2.b) / (Math.Pow(c2.a, 2) + Math.Pow(c2.b, 2)), (c2.a * c1.b - c1.a * c2.b) / (Math.Pow(c2.a, 2) + Math.Pow(c2.b, 2)));
        }
        public static ComplexNumber operator %(ComplexNumber c, int n)
        {
            double norm = Math.Sqrt(Math.Pow(c.a, 2) + Math.Pow(c.b, 2));
            double theta = Math.Atan2(c.b, c.a);
            return new ComplexNumber(Math.Pow(norm,n)*Math.Cos(n*theta), Math.Pow(norm,n)*Math.Sin(n*theta));
        }
        public List<ComplexNumber> Roots(int n)
        {
            double norm = Math.Sqrt(Math.Pow(this.a, 2) + Math.Pow(this.b, 2));
            double theta = Math.Atan2(this.b, this.a);
            ComplexNumber r = new ComplexNumber();
            List<ComplexNumber> roots = new List<ComplexNumber>();
            for (int k = 0; k <= n-1; k++)
            {
                r = new ComplexNumber(Math.Pow(norm, 1.0 / n)*Math.Cos((theta+2*k*Math.PI)/n), Math.Pow(norm, 1.0 / n) * Math.Sin((theta + 2 * k * Math.PI) / n));
                roots.Add(r);
            }
            return roots;
        }
    }
}
