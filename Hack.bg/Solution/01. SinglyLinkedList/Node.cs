namespace _01._SinglyLinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Node
    {
        public Node(int d)
        {
            this.Data = d;
            this.Next = null;
        }

        public int Data { get; set; }

        public Node Next { get; set; }
    }
}