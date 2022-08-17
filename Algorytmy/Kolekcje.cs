using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(2);
            list.Add("Szymon");
            list.Add(new Auto("BMW"));
            Console.WriteLine(list.Count);
            Console.WriteLine(list[2]); //BMW
            Console.WriteLine();
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            list.RemoveAt(1);
            Console.WriteLine(list.Count);


            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(5, "Ania"); //Indeksy nie są ustawiane w kolejności numerycznej
            dict.Add(2, "Kasia"); //Nie można dodać wartości o takim samym kluczu bo to wyjątek
            if (!dict.ContainsKey(3))
                dict.Add(3, "Ola");
            foreach(var i in dict)
            {
                Console.WriteLine("{0} : {1}",i.Key,i.Value);
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine(queue.Peek()); // To co na samej górze
            Console.WriteLine(queue.Dequeue()); //1
            Console.WriteLine(queue.Peek()); //2 bo 1 już ściągnięte 


            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine(stack.Peek()); //4 odwrotnie niż kolejka
            stack.Pop();
            Console.WriteLine(stack.Peek());

            Console.ReadKey();
        }

    }
    class Auto
    {
        public string nazwa { get; set; }
        public Auto(string marka)
        {
            nazwa = marka;
        }
        public override string ToString()
        {
            return nazwa;
        }

    }

}
