using LinkedList3.cs;
using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace LinkedList3;
class list3
{
   public static void Main()
    {
        Addlast Adlast = new Addlast();
        Adlast.Add(70);
        Adlast.Add(56);
        Adlast.Add(50);
        Adlast.InsertAtParticularPosition(2, 30);
        Adlast.Display();
    }
}
