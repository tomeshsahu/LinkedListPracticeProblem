using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPracticeProblem
{
    internal class UC6SearchLinkedList
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
        public int Search(int addedData)
        {
            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data == addedData)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        public Node InsertAtPerticularPosition(int position, int data)
        {
            var newNode = new Node(data);
            if (this.head == null)
            {
                return newNode;
            }
            if (position == 0)
            {
                newNode.next = head;
                head = newNode;
                return head;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {


                prev = current;
                current = current.next;
                count++;
            }
            newNode.next = prev.next;
            prev.next = newNode;
            return this.head;
        }
        public void DeleteNodeAtPerticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            Node temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null) { }
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = null; ;
        }
        public Node DeleteLastIndex()
        {
            if (head == null)
            {
                return null;
            }
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
    }
}