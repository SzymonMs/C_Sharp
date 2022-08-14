using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy
{
    internal class Item
    {
        public string name_;
        public double prize_;
        public enum VAT_ : int { A = 23, B = 8, C = 0 };
        public int counter_;
        public int vat_;
        public Item(string name, double prize, int counter, VAT_ vat)
        {
            name_ = name;
            prize_ = prize;
            counter_ = counter;
            if (vat == VAT_.A)
                vat_ = 23;
            if (vat == VAT_.B)
                vat_ = 8;
            if (vat == VAT_.C)
                vat_ = 0;
        }
    }
}
