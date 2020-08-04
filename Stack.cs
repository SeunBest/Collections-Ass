using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Collections_Ass
{
    class Stack
    {
        public Stack() 
        { 
            Working = new List<int>();
        }

        public List<int> Working;  
        

        public bool isEmpty()
        {
            bool Empty = Working.Count < 1;
            if (Empty)
            {
                Console.WriteLine("Stack is empty!");
            }
            else
            {
                Console.WriteLine("Stack is not empty!");
            }
            return Empty;
        }

        public void Push(int number)
        {
            Working.Add(number);
            Console.WriteLine($"{number} added successfully to stack");
        }

        public int Pop()
        {
            int last = Working.Count - 1;
            int popped = Working[last];
            Working.RemoveAt(last);
            Console.WriteLine($"Last number {popped} removed successfully from stack");
            return popped;
        }


        public int  Peek()
        {
            int last = Working.Count - 1;
            int peek = Working[last];
            Console.WriteLine($"The last number in stack is {peek}");
            return peek;
        }

        public int Size()
        {
            Console.WriteLine($"There are {Working.Count} in the Stack");
            return Working.Count;
        }

        public void Print()
        {
            int last = Working.Count - 1;
            Console.WriteLine("Below are the numbers in the stack");
            for ( int i = last; i >= 0; i--)
            {
                Console.WriteLine(Working[i]);
            }
        }
    }

}
