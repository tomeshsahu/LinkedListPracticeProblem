using System;
using System.Collections.Generic;
using LinkedListPracticeProblem;

Console.WriteLine("Welcome Linklist Practice Problem");
Console.WriteLine("UC1-CrateLInkList");
Console.WriteLine("Take an option to execute");
int Option = Convert.ToInt32(Console.ReadLine());
switch (Option)
{
    case 1:
        LinkedList list = new LinkedList();
        list.Add(56);
        list.Add(30);
        list.Add(70);
        list.Display(); 

        break;
    default:
        Console.WriteLine("Enter proper Option to Execute");
        break;
}