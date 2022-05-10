﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPracticeProblem;

class LinkedList
{
    public Node head; //new 
   // public int temp;

    internal void Add(int data)
    {
        Node node = new Node(data);
        if (this.head == null)
            this.head = node;
        else
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
        }

        Console.WriteLine(" inserted into the linked list" + node.data);
    }
}
  