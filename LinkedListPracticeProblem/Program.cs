using System;
using System.Collections.Generic;
using LinkedListPracticeProblem;

Console.WriteLine("Welcome Linklist Practice Problem");
Console.WriteLine("1. UC1-CrateLInkList\n2. UC2-Append LinkLis\n3. UC3-Insert Between ");
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

    case 2:
        UC2AppendLinkedList list1 = new UC2AppendLinkedList();
        list1.Add(56);
        list1.Append(30);
        list1.Append(70);
        break;

    case 3:
        UC3AddBetween list2 = new UC3AddBetween();
        list2.Add(56);
        list2.Add(70);
        int a = list2.Search(56);
        list2.InsertAtPerticularPosition(a + 1, 30);
        list2.Display();
        break;


    default:
        Console.WriteLine("Enter proper Option to Execute");
        break;
}