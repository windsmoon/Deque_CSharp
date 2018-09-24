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
        Console.ReadKey();
    }
}
