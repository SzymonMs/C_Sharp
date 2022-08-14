using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy
{
    static class RatioCalculator
    {
        public static Ratio AddRatio(Ratio ratio1, Ratio ratio2)
        {
            int denominator = 1;
            int nominator = 0;
            nominator = ratio1.nominator_ * ratio2.denominator_ + ratio2.nominator_ * ratio1.denominator_;
            denominator = ratio1.denominator_ * ratio2.denominator_;
            int gcd = Program.Euclides(nominator, denominator);
            nominator = nominator / gcd;
            denominator = denominator / gcd;
            return new Ratio(nominator, denominator);
        }        
        public static Ratio SubRatio(Ratio ratio1, Ratio ratio2)
        {
            int denominator = 1;
            int nominator = 0;
            nominator = ratio1.nominator_ * ratio2.denominator_ - ratio2.nominator_ * ratio1.denominator_;
            denominator = ratio1.denominator_ * ratio2.denominator_;
            int gcd = Program.Euclides(nominator, denominator);
            nominator = nominator / gcd;
            denominator = denominator / gcd;
            return new Ratio(nominator, denominator);
        }
        public static Ratio MulRatio(Ratio ratio1, Ratio ratio2)
        {
            int denominator = 1;
            int nominator = 0;
            nominator = ratio1.nominator_ * ratio2.nominator_;
            denominator = ratio1.denominator_ * ratio2.denominator_;
            int gcd = Program.Euclides(nominator, denominator);
            nominator = nominator / gcd;
            denominator = denominator / gcd;
            return new Ratio(nominator, denominator);
        } 
        public static Ratio DivRatio(Ratio ratio1, Ratio ratio2)
        {
            int denominator = 1;
            int nominator = 0;
            nominator = ratio1.nominator_ * ratio2.denominator_;
            denominator = ratio1.denominator_ * ratio2.nominator_;
            int gcd = Program.Euclides(nominator, denominator);
            nominator = nominator / gcd;
            denominator = denominator / gcd;
            return new Ratio(nominator, denominator);
        }

    }
}
