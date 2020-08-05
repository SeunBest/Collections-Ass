using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Ass
{
    class DoubleList<T>
    {
        /// <summary>
        /// Declaration of the properties of the LinkedList
        /// </summary>
        public int count;
        public Node<T> Head;
        public Node<T> Tail;
         
        //constructor for the doubly linked list, initializing the head and tail to null 
        public DoubleList()
        {
            Head = null;
            count = 0;
            Tail = null;
        }

        //Adds to head of list
        public void AddHead(T item)
        {
            //get head into a temporary variable
            var hdd = Head;
            //make the new item a node
            var add = new Node<T>(item);
            //Head is now the new item
            Head = add;
            
            Head.Next = hdd; 
            if (count == 0)
            {
                Tail = Head;
            } else
            {
                hdd.Previous = Head;
            }
            count++;
        }

        // Adds to tail of List
        public void AddTail(T item)
        {
            //turn item to node
            var add = new Node<T>(item);
            //for empty list
            if (count == 0)
            {
                Head = add;
            } else
            {
                Tail.Next = add;
                add.Previous = Tail;
                count++;
            }
        }

        //searches for an item and returns it's node
        public Node<T> Search(T item)
        {
            Node<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return current;
                }
                else
                {
                    current = current.Next;
                }
            }
            return null;
        }

        //checks if an item is present in the List
        public bool Check(T item)
        {
            return Search(item) != null;
        }

        //checks if list is empty
        public bool IsEmpty()
        {
            return count < 1;
        }
        
        //returns size of list
        public int Size()
        {
            return count;
        }

        public void Print ()
        {
            var current = Head;
            if (Head == null)
            {
                Console.WriteLine("I am tired");
            }
            while (current.Next != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}
