using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy
{
    internal class Ratio
    {
        public int denominator_;
        public int nominator_;
        public Ratio() { }
        public Ratio(int nominator, int denominator)
        {
            denominator_ = denominator;
            nominator_ = nominator;
        }
        public void RatioPrint()
        {
            if (nominator_ % denominator_ == 0)
                Console.WriteLine("{0}", nominator_ / denominator_);
            else if(nominator_ > denominator_ && nominator_%denominator_ !=0)
                Console.WriteLine("{0} i {1}/{2}",nominator_/denominator_,nominator_-nominator_/denominator_*denominator_,denominator_);
            else
                Console.WriteLine("{0}/{1}", nominator_, denominator_);
        }
        public static Ratio operator +(Ratio r1, Ratio r2)
        {
            return RatioCalculator.AddRatio(r1, r2);
        }

    }
}
