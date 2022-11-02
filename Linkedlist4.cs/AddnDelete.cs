using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linkedlist4.cs
{
    class AddnDelete
    {
        Node4 Head;  //new node pointing to head is created
        public void Add(int x)
        {
            Node4 nd = new Node4(x);
            if(this.Head == null)
                this.Head = nd;
            else
            {
                Node4 temp = Head;
                while(temp.next !=null)
                {
                    temp = temp.next;
                }
                temp.next = nd;
            }
            Console.Write("\n{0} is inserted into the list", nd.data +);

        }
        public void Display()
        {
            Node4 temp = Head;
            if (temp == null)
                Console.WriteLine("The linked list is empty");
            while(temp!=null)
            {
                Console.WriteLine(temp.data + " \n");
                temp = temp.next;
            }
        }
        internal Node4 RemoveFirstNode()
        {
            if (this.Head == null)
                return null;
            this.Head = this.Head.next;
            return this.Head;
        }
        internal Node4 RemovaLastNode()
        {
            if (Head == null)
                return null;
            if (Head.next == null)
                return null;
            Node4 newNode = Head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return Head;
        }
        internal int Search(int Data)
        {
            Node4 nd = this.Head;
            int count = 0;
            while (nd != null)
            {
                if(nd.data == Data)
                {
                    return count;
                }
                nd = nd.next;
                count++;                
            }
            return count;
    
        }
    }
}
