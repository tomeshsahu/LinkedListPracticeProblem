using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPracticeProblem;

internal class UC2AppendLinkedList
{
    public Node head;
    public void Add(int data)
    {
        Node node = new Node(data);
        if (this.head == null)
        {
            this.head = node;
        }
        else
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
            Console.WriteLine(node.data + " " + "inserted into Linked List ");
        }
    }
    public void Append(int data)
    {
        Node node = new Node(data);
        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = node;
        Console.WriteLine(node.data + " " + "Appended into Linked List ");
        Display();

    }
    public void Display()
    {
        Node temp = head;
        if (temp == null)
        {
            Console.WriteLine("There is no element int he linked List");
        }
        while (temp != null)
        {
            Console.Write(temp.data + "  ");
            temp = temp.next;
        }
        Console.WriteLine(" ");
    }
}
