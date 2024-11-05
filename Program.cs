using System;
using System.Collections.Generic;

namespace HomeWork3
{
    class Program
    {
        static void Main()
        {
            MyLinkedList<int> MLL = new MyLinkedList<int>();
            Console.WriteLine("enter the length of the linked list");
            int length=int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Add a new element ");
                int num=int.Parse(Console.ReadLine());
                MLL.AddLast(num);
            }
            MLL.Print();

            Console.WriteLine("enter a new element at the first ");
            int num2=int.Parse(Console.ReadLine());
            MLL.AddFirst(num2);
            MLL.Print();

            Console.WriteLine("delete the last element ");
            MLL.DeleteLast();
            MLL.Print();

            Console.WriteLine("delete the first element ");
            MLL.DeleteFirst();
            MLL.Print();

            Console.WriteLine("adding a new element at any available position ");
            Console.WriteLine("enter the value ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the position ");
            int pos = int.Parse(Console.ReadLine());
            MLL.AddAtPosition(pos, num3);
            Console.WriteLine("-------");
            MLL.Print();

            Console.WriteLine("thank you");
        }
    }
}
        

    
