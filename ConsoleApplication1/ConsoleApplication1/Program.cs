  ﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue('a');
            q.Enqueue('b');
            q.Enqueue('c');
            q.Enqueue('d');
            Console.WriteLine("Current Characters Present in the Queue is : ");
            foreach (char c in q)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            q.Enqueue('e');
            q.Enqueue('f');
            Console.WriteLine("Current Characters in Queue after added elements : ");
            foreach (char c in q)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            char x = (char)q.Dequeue();
            Console.WriteLine($"The First Character in Queue removed is : {x}");
            char y = (char)q.Dequeue();
            Console.WriteLine();
            Console.WriteLine($"The Second Character in Queue removed is : {y}");
            Console.WriteLine("Current Characters Queue after removed elements");
            foreach (char c in q)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
