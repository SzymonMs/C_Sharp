using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy
{
    internal class Receipt
    {
        public long nipR_;
        public long nipT_;
        public List<Item> items_ = new List<Item>() { new Item(" ", 0, 0, Item.VAT_.A) };
        public Receipt(long nipR, long nipT)
        {
            nipR_ = nipR;
            nipT_ = nipT;
        }
        public void Add_Item(Item item)
        {
            items_.Add(item);
        }
        public void Print()
        {
            if (items_.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("|||||||||||||| FAKTURA |||||||||||||||");
                Console.WriteLine("======================================");
                Console.WriteLine("Sprzedawaca: {0}  Odbiorca: {1}", nipT_, nipR_);
                Console.WriteLine();
                double sumNetto = 0;
                double sumBrutto = 0;
                items_.RemoveAt(0);
                for (int i = 0; i < items_.Count; i++)
                {
                    double netto = items_[i].prize_ * items_[i].counter_;
                    double brutto = netto + netto * items_[i].vat_ / 100.0;
                    sumBrutto += brutto;
                    sumNetto += netto;
                    Console.WriteLine("{0}. {1}  | {2} | {3} | {4} | {5} | {6}", i+1, items_[i].name_, items_[i].prize_, items_[i].vat_, items_[i].counter_, netto, brutto);
                }
                Console.WriteLine("                        RAZEM: {0} | {1}", sumNetto, sumBrutto);
                Console.WriteLine();
                Console.WriteLine();
            }

        }
        ~Receipt()
        {

        }
    }
}
