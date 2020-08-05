using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Collections_Ass
{
    class Node<T>
    {
        //properties for node
        //initialize value
        public Node(T value)
        {
            this.Value = value;
        }
        public Node<T> Previous { get; set; }
        public Node<T> Next { get; set; }

        public T Value;
    }
}
