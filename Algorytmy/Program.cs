using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ALGORYTMY
            double min = 0;
            double max = 0;
            double[] array = { 1.0, 2.0, 3.0, -1.1, 20.0 };
            MinMax(array, ref min, ref max);
            Console.WriteLine("MinMax:");
            Console.WriteLine("{0}, {1}", min, max);
            Console.WriteLine("Silnia:");
            Console.WriteLine(Factorial(15));
            Console.WriteLine("Czy to liczba pierwsza:");
            Console.WriteLine(IsPrime(100));
            PrimeNumbers(1, 20);
            Console.WriteLine(Leibnitz(0.00001));
            HashSquare(7, leftDiagonal: true, rightDiagonal: true);
            Console.WriteLine(Euclides(15,6));

            //FAKTURA
            Receipt receipt = new Receipt(123, 1234);
            receipt.Add_Item(new Item("śruba", 12.2, 10, Item.VAT_.B));
            receipt.Add_Item(new Item("korek", 15.6, 13, Item.VAT_.A));
            receipt.Add_Item(new Item("masło", 66.7, 12, Item.VAT_.A));
            receipt.Add_Item(new Item("klucz", 75.6, 30, Item.VAT_.A));
            receipt.Add_Item(new Item("widro", 9.99, 4, Item.VAT_.C));
            receipt.Add_Item(new Item("widły", 22.9, 1, Item.VAT_.A));
            receipt.Print();

            //RATIO
            Ratio ratio1 = new Ratio(7, 3);
            Ratio ratio2 = new Ratio(1,1);
            RatioCalculator.MulRatio(ratio1,ratio2).RatioPrint();

            Console.ReadKey();
        }
        /// <summary>
        /// Find min and max value from array
        /// </summary>
        /// <param name="arr"> Array of double numbers</param>
        /// <param name="min"> Variable for min value</param>
        /// <param name="max"> Variable for max value</param>
        static void MinMax(double[] arr, ref double min, ref double max)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
                if (arr[i] > max)
                    max = arr[i];
            }
        }
        /// <summary>
        /// Factorial of number
        /// </summary>
        /// <param name="num">Number</param>
        /// <returns>Factorial of number</returns>
        static UInt64 Factorial(int num)
        {
            UInt64 factorial = 1;
            while (num > 0)
            {
                factorial = factorial * (UInt64)num;
                num -= 1;
            }
            return factorial;
        }
        /// <summary>
        /// Is it a prime number
        /// </summary>
        /// <param name="num">Number</param>
        /// <returns>Bool value: true - is prime, false- is not prime</returns>
        static bool IsPrime(int num)
        {
            bool isPrime = true;
            for (int i = 2; i <= (int)Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
        /// <summary>
        /// List of prime numbers in range
        /// </summary>
        /// <param name="left">Left boundary of the range</param>
        /// <param name="right">Right boundary of the range</param>
        static void PrimeNumbers(int left, int right)
        {
            int[] array = new int[right - left];
            int num = 0;
            int len = 0;
            for (int i = left; i <= right; i++)
            {
                if (IsPrime(i) == true && i != 1)
                {
                    array[num] = i;
                    num++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                    len++;
            }
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("number " + i + ". " + array[i]);
            }
        }
        /// <summary>
        /// Leibnitz's approximation of PI
        /// </summary>
        /// <param name="stop_at">Value of error</param>
        /// <returns>Apx. of PI</returns>
        static double Leibnitz(double stop_at)
        {
            double pi = 1;
            double counter = 0;
            int number = 3;

            while (1.0 / number > stop_at)
            {
                if (counter % 2 == 0)
                    pi = pi - 1.0 / number;
                else
                    pi = pi + 1.0 / number;
                counter++;
                number = number + 2;
            }
            pi = pi * 4.0;
            return pi;
        }
        /// <summary>
        /// Hash Square Art
        /// </summary>
        /// <param name="a">Size of Square</param>
        /// <param name="leftDiagonal">Is there a left diagonal</param>
        /// <param name="rightDiagonal">Is there a right diagonal</param>
        static void HashSquare(int a, bool leftDiagonal = false, bool rightDiagonal = false)
        {
            if (leftDiagonal == false && rightDiagonal == false)
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        if (i == 0 || i == a - 1 || j == 0 || j == a - 1)
                            Console.Write("#");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            if (leftDiagonal == true && rightDiagonal == false)
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        if (i == 0 || i == a - 1 || j == 0 || j == a - 1 || i == j)
                            Console.Write("#");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            if (leftDiagonal == true && rightDiagonal == true)
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        if (i == 0 || i == a - 1 || j == 0 || j == i || i + j == a - 1 || j == a - 1)
                            Console.Write("#");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

        }
        /// <summary>
        /// Euclide's Algorithm
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Sedond number</param>
        /// <returns>GCD of a and b</returns>
        public static int Euclides(int a, int b)
        {
        Euclides:
            int c = a % b;
            a = b;
            b = c;
            if (b == 0)
                return a;
            else
                goto Euclides;
        }
    }
}
