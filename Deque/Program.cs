using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        List<int> list = new List<int>();
        list.Add(0);
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        Deque<int> deque = new Deque<int>(list, true);
        deque.PrintToConsole();
        Console.WriteLine();
        deque.RemoveHead();
        deque.RemoveHead();
        deque.AddTail(5);
        deque.AddHead(1);
        deque.AddHead(0);
        deque.AddHead(-1);
        deque.AddHead(-2);
        deque.AddHead(-3);
        deque.PrintToConsole();
        Console.WriteLine();
        deque.RemoveTail();
        deque.RemoveTail();
        deque.PrintToConsole();
        Console.WriteLine();
        deque.AddTail(4);
        deque.AddTail(5);
        deque.AddTail(6);
        deque.AddTail(7);
        deque.AddTail(8);
        deque.PrintToConsole();
        Console.WriteLine();

        foreach (var item in deque)
        {
            Console.WriteLine(item);
        }

        //int[] ints = new int[20];
        //deque.CopyTo(ints, 3);

        //foreach (int number in ints)
        //{
        //    Console.WriteLine(number);
        //}

        Console.ReadKey();
    }
}
