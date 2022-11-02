using LinkedList1.cs;
using System;
namespace LinkedList;
class SimpleLinkedList
{
    public static void Main()
    {
        //creating object of class AddList
        AddList List = new AddList();
        //calling the Add method via object of the class
        List.Add(56);
        List.Add(30);
        List.Add(70);
        List.Add(23);
        //calling the display method via object of the class
        List.Display();
    }
}