using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList2.cs
{
    internal class AddList
    {
        internal Node head; //new
        public AddList()
        {
            head = null;
        }
        internal void AddFirst(int data)
        {
            Node NN = new Node(data);
            NN.next = head;
            head = NN;
            Console.WriteLine("{0} inserted into the linked list", NN.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
                Console.Write("The list is empty.");
            while(temp != null)
            {
                Console.WriteLine(temp.data + " ");
                    temp = temp.next;
            }

        }
    }
}
