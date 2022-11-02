using Linkedlist4.cs;
using System;
namespace PopLast;
class Del
{
    public static void Main(string[] args)
    {
        AddnDelete AnD = new AddnDelete();
        AnD.Add(30);
        AnD.Add(56);
        AnD.Add(70);
        AnD.Display();
        //AnD.RemoveFirstNode();
       // AnD.Display();
        AnD.Add(98);
        AnD.Add(78);
        AnD.Display();
        //AnD.RemovaLastNode();
        AnD.Search(70);
    }
}