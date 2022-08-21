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
            Console.WriteLine(Euclides(15, 6));

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
            Ratio ratio2 = new Ratio(1, 1);
            RatioCalculator.MulRatio(ratio1, ratio2).RatioPrint();
            Ratio ratio3 = ratio1 + ratio2;
            ratio3.RatioPrint();
            Console.WriteLine();

            //ALGORYTMY 2
            Console.WriteLine(IsPalindrome("natan"));
            List<int> list = FindAll("ala ma kota", 'a');
            ListPrint(list);
            Console.WriteLine(FindLongestWord("Ala ma kota kot jezdzi na Roombie"));
            List<string> list2 = new List<string>();
            List<double> list3 = new List<double>() { 1.2, 3.3, 2.1, 7 };
            list2 = SplitWord("olamamakot", 'a');
            foreach (string word in list2)
                Console.WriteLine(word);
            Console.WriteLine(FindAndReplace("kot kot kotek koteczek", "kot", "ala"));
            ListDoublePrint(BubbleSort(list3, true));

            //Wektor
            Vector3D v1 = new Vector3D(1, 1, 1);
            Vector3D v2 = new Vector3D(2, -1, 10.2);
            v1.PrintVector();
            Vector3D v3 = v1 + v2;
            double scalar = v1 * v2;
            Console.WriteLine(scalar);
            v3.PrintVector();
            Console.WriteLine();

            //Cmplx
            ComplexNumber cmplx1 = new ComplexNumber(1,3);
            ComplexNumber cmplx2 = new ComplexNumber(0, 2);
            int n = 2;
            ComplexNumber cmplx4 = cmplx1 % n;
            ComplexNumber cmplx3 = cmplx1 / cmplx2;
            cmplx3.PrintCmplx();
            cmplx4.PrintCmplx();
            List<ComplexNumber> roots = cmplx1.Roots(5);
            Console.WriteLine("Pierwiastki");
            foreach (var item in roots)
            {
                item.PrintCmplx();
            }
            Console.WriteLine();
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
        /// <summary>
        /// Is it a palindrome
        /// </summary>
        /// <param name="word">Word</param>
        /// <returns>Bool value: true- is palindrome, false- is not palindrome</returns>
        static bool IsPalindrome(string word)
        {
            bool isPalindrome = true;
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
                else
                    continue;
            }
            return isPalindrome;
        }
        /// <summary>
        /// Find all index of character in string
        /// </summary>
        /// <param name="word">Word</param>
        /// <param name="sign">Character</param>
        /// <returns>List of index/ int</returns>
        static List<int> FindAll(string word, char sign)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == sign)
                    list.Add(i);
            }
            return list;
        }
        /// <summary>
        /// Print List of ints numbers
        /// </summary>
        /// <param name="list">List to print</param>
        static void ListPrint(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Find the longest word in sentence
        /// </summary>
        /// <param name="word">Sentence</param>
        /// <returns>The longest word</returns>
        static string FindLongestWord(string word)
        {
            string maxWord = "";
            string[] words = word.Split(' ');
            int max = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > max)
                {
                    max = words[i].Length;
                    maxWord = words[i];
                }
            }

            return maxWord;
        }
        /// <summary>
        /// Own function to split string with user separator
        /// </summary>
        /// <param name="word">Sentence</param>
        /// <param name="separator">Separator character</param>
        /// <returns>List's strings with words</returns>
        static List<string> SplitWord(string word, char separator)
        {
            List<string> list = new List<string>();
            List<int> index = FindAll(word, separator);
            int indexStart = 0;
            string help = "";
            for (int i = 0; i < index.Count; i++)
            {

                for (int j = indexStart; j < index[i]; j++)
                {
                    help += word[j];
                }
                indexStart = index[i] + 1;
                list.Add(help);
                help = "";
            }
            for (int j = indexStart; j < word.Length; j++)
            {
                help += word[j];
            }
            list.Add(help);
            return list;
        }
        /// <summary>
        /// Find all word1 in input and replace on word2
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="word1">Word to replace</param>
        /// <param name="word2">Replace</param>
        /// <returns>Word with replace</returns>
        static string FindAndReplace(string input, string word1, string word2)
        {
            string output = input;
            output = output.Replace(word1, word2);
            return output;
        }
        /// <summary>
        /// Bubble sort list of double numbers
        /// </summary>
        /// <param name="list">List of double numbers</param>
        /// <param name="order">If order is false- ascendning order, else if order is true- descending order</param>
        /// <returns></returns>
        static List<double> BubbleSort(List<double> list, bool order = false)
        {
            int n = list.Count;
            bool isChange = true;
            double temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (order == true)
                    {
                        if (list[j] < list[j + 1])
                        {
                            temp = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = temp;
                        }
                    }
                    else
                    {
                        if (list[j] > list[j + 1])
                        {
                            temp = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = temp;
                        }
                    }


                }

            }
            return list;
        }
        /// <summary>
        /// Print list of double
        /// </summary>
        /// <param name="list">List</param>
        static void ListDoublePrint(List<double> list)
        {
            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
