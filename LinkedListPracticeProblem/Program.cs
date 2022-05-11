using System;
using System.Collections.Generic;
using LinkedListPracticeProblem;

Console.WriteLine("Welcome to Linkedlist Practice Problem");
bool check = true;
while (check)
{
    Console.WriteLine("Welcome Linklist Practice Problem");
    Console.WriteLine("1. UC1-CrateLInkList\n2. UC2-Append LinkLis\n3. UC3-Insert Between\n4. UC4- DeleteFirstElement\n5. UC5- DeleteLastElement\n6. UC6-SearchLinkedList\n7. UC7-AddnumberAfterElement");
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

        case 4:
            UC4DeleteFirstElement list3 = new UC4DeleteFirstElement();
            Console.WriteLine("Enter the position of the Element");
            int index = Convert.ToInt32(Console.ReadLine());
            list3.DeleteNodeAtPerticularPosition(index);
            list3.Display();
            break;

        case 5:
            UC5DeleteLastElement list4 = new UC5DeleteLastElement();
            list4.DeleteLastIndex();
            list4.Display();
            break;

        case 6:
            UC6SearchLinkedList list5 = new UC6SearchLinkedList();
            int node = list5.Search(30);
            Console.WriteLine("element present on the index:-> " + node);
            list5.Display();
            break;

        case 7:
            UC7AddNumberAfterElement list6 = new UC7AddNumberAfterElement();
            list6.Add(56);
            list6.Add(30);
            list6.Add(70);
            int b = list6.Search(30);
            list6.InsertAtPerticularPosition(b + 1, 40);
            list6.Display();
            break;

        case 0:
            check = false;
            break;
        default:
            Console.WriteLine("Enter proper Option to Execute");
            break;
    }
}