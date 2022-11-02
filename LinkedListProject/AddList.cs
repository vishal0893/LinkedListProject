﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1.cs
{
    internal class AddList
    {
        internal Node head; //new 
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
                Console.WriteLine("The List is empty.\n");
            while(temp!=null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
