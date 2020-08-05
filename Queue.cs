using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Ass
{
    class Queue<T>
    {
        public Queue()
        {
            Work = new List<T>();
        }

        public List<T> Work;

        //checks if queue is empty
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

        //adds item to queue
        public void Enqueue(T number)
        {
            Work.Add(number);
            Console.WriteLine($"{number} added successfully to queue");
        }

        //remove item from queue
        public T Dequeue()
        {
            T popped = Work[0];
            Work.RemoveAt(0);
            Console.WriteLine($"Last number {popped} removed successfully from Queue");
            return popped;
        }

        //get the number of items in queue
        public int Size()
        {
            Console.WriteLine($"There are {Work.Count} in the Queue");
            return Work.Count;
        }

        //lists out the items in the queue
        public void Print()
        {
            int last = Work.Count - 1;
            Console.WriteLine("Below are the numbers in the queue");
            foreach (T i in Work)
             {
               Console.WriteLine(i);
             }
        }
    }
}
