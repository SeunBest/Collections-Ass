using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Ass
{
    class DoubleList<T>
    {
        public int count;
        public Node<T> Head;
        public Node<T> Tail;
               
        public DoubleList()
        {
            Head = null;
            count = 0;
            Tail = null;
        }
        public void AddHead(T item)
        {
            var hdd = Head;
            var add = new Node<T>(item);
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

        public void AddTail(T item)
        {
            var add = new Node<T>(item);
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

        public T Search(T item)
        {
            Node<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return current.Value;
                }
                else
                {
                    current = current.Next;
                }
            }
            return default;
        }

        public bool Check(T item)
        {
            return Search(item) != null;
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
