﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Collections_Ass
{
    class Stack<T>
    {
        public Stack() 
        { 
            Working = new List<T>();
        }

        public List<T> Working;

        //checks if stack is empty
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

        //adds item to stack
        public void Push(T number)
        {
            Working.Add(number);
            Console.WriteLine($"{number} added successfully to stack");
        }

        //remove item from stack and return it to caller
        public T Pop()
        {
            int last = Working.Count - 1;
            T popped = Working[last];
            Working.RemoveAt(last);
            Console.WriteLine($"Last number {popped} removed successfully from stack");
            return popped;
        }

        //checks last number in the stack
        public T  Peek()
        {
            int last = Working.Count - 1;
            T peek = Working[last];
            Console.WriteLine($"The last number in stack is {peek}");
            return peek;
        }

        //returns the number of items in stack
        public int Size()
        {
            Console.WriteLine($"There are {Working.Count} in the Stack");
            return Working.Count;
        }

        //lists out the items in the stack
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
