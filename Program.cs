using System;
using System.Threading;
using System.Collections.Generic;

namespace Collections_Ass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program demonstrates the behavior of some complex data structures");
            Console.WriteLine("Starting with a stack");
            Stack<int> guy = new Stack<int>();
            Thread.Sleep(2000);
            Console.WriteLine("New Stack created successfully");
            Console.WriteLine("Checking if it's empty");
            Thread.Sleep(1000);
            guy.isEmpty();

            Console.WriteLine("Now let's push a few numbers to the Stack");
            guy.Push(1);
            Thread.Sleep(1000);
            guy.Push(2);
            Thread.Sleep(1000);
            guy.Push(3);
            Thread.Sleep(1000);
            guy.Push(4);
            Thread.Sleep(1000);
            guy.Push(5);
            Thread.Sleep(1000);

            Console.WriteLine("Let's see the last number that was added to the Stack");
            Thread.Sleep(1000);
            guy.Peek();
            Thread.Sleep(1000);

            Console.WriteLine("Now let us remove that number that was last added to the Stack that we just viewed");
            Thread.Sleep(1000);
            guy.Pop();
            Thread.Sleep(1000);

            Console.WriteLine("Let's count how many numbers we have in our Stack");
            Thread.Sleep(1000);
            Console.WriteLine("Counting...");
            Thread.Sleep(1000);
            guy.Size();
            Thread.Sleep(1000);

            Console.WriteLine("Now, let us check if our stack is still empty");
            Thread.Sleep(1000);
            guy.isEmpty();
            Thread.Sleep(1000);

            Console.WriteLine("Finally on stacks, let us print out the numbers in our stack");
            Thread.Sleep(1000);
            guy.Print();
            Thread.Sleep(2000);


            Console.WriteLine("Now, moving on to a Queue");
            Queue<int> guys = new Queue<int>();
            Thread.Sleep(2000);
            Console.WriteLine("New Queue created successfully");
            Console.WriteLine("Checking if it's empty");
            Thread.Sleep(1000);
            guys.isEmpty();

            Console.WriteLine("Now let's push a few numbers to the Queue");
            guys.Enqueue(1);
            Thread.Sleep(1000);
            guys.Enqueue(2);
            Thread.Sleep(1000);
            guys.Enqueue(3);
            Thread.Sleep(1000);
            guys.Enqueue(4);
            Thread.Sleep(1000);
            guys.Enqueue(5);
            Thread.Sleep(1000);

            Console.WriteLine("Now lets remove that number that was added first to the Queue that we just viewed");
            Thread.Sleep(1000);
            guys.Dequeue();
            Thread.Sleep(1000);

            Console.WriteLine("Let's count how many numbers we have in our Queue");
            Thread.Sleep(1000);
            Console.WriteLine("Counting...");
            Thread.Sleep(1000);
            guys.Size();
            Thread.Sleep(1000);

            Console.WriteLine("Now, let us check if our Queue is still empty");
            Thread.Sleep(1000);
            guys.isEmpty();
            Thread.Sleep(1000);

            Console.WriteLine("Finally on Queues, let us print out the numbers in our Queue");
            Thread.Sleep(1000);
            guys.Print();

            var seun = new DoubleList<int>();
            seun.AddHead(2);
            seun.AddHead(3);
            seun.AddTail(4);
            seun.AddTail(5);
            Console.WriteLine("\n\n");
            Console.WriteLine("For LinkedList");
            Console.WriteLine(seun.Search(3));
            Console.WriteLine(seun.Search(2));
            seun.Print();
           // Console.WriteLine(seun.Check(2));
            //Console.WriteLine(seun.Check(20));
            //Console.WriteLine(seun.Add(5));

            //seun.Print();
            






        }
    }
}
