using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList3.cs
{
    internal class Addlast
    {
        internal Node3 head; //new 
        internal void Add(int data)
        {
            Node3 node = new Node3(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node3 temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        internal Node3 InsertAtParticularPosition(int position, int data)
        {
            var newNode = new Node3(data);
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
               
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node3 node = new Node3(data);
                node = this.head;
                while (position >2) //for position greater than 2
                {
                    node= node.next;
                    position--;                 
                               
                }
                newNode.next = node.next;
                node.next = newNode;             
            }
           return head;
        }
        internal void Display()
        {
            Node3 temp = this.head;
            if (temp == null)
                Console.WriteLine("The List is empty.\n");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
