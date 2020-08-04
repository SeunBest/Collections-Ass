﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Ass
{
    class Queue 
    {
        public Queue()
        {
            Work = new List<int>();
        }

        public List<int> Work;


        public bool isEmpty()
        {
            bool Empty = Work.Count < 1;
            if (Empty)
            {
                Console.WriteLine("Queue is empty!");
            }
            else
            {
                Console.WriteLine("Queue is not empty!");
            }
            return Empty;
        }

        public void Enqueue(int number)
        {
            Work.Add(number);
            Console.WriteLine($"{number} added successfully to queue");
        }

        public int Dequeue()
        {
            int popped = Work[0];
            Work.RemoveAt(0);
            Console.WriteLine($"Last number {popped} removed successfully from Queue");
            return popped;
        }

        public int Size()
        {
            Console.WriteLine($"There are {Work.Count} in the Queue");
            return Work.Count;
        }

        public void Print()
        {
            int last = Work.Count - 1;
            Console.WriteLine("Below are the numbers in the queue");
            foreach (int i in Work)
             {
               Console.WriteLine(i);
             }
        }
    }
}