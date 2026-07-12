using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace oop
{
    internal class LinkedList_problem
    {
        public class ListNode
        {
            public int Data;         
            public ListNode Next;    

            public ListNode(int data)
            {
                Data = data;
                Next = null;
            }
        }

        public class linkedlist
        {
            public ListNode Head;
            public linkedlist()
            {
                Head = null;
            }


            public void Append(int data)
            {
                ListNode newNode = new ListNode(data);
                if(Head == null)
                {
                    Head = newNode;
                    return;
                }

                ListNode lastnode = Head;
                while(lastnode.Next != null)
                {
                    lastnode = lastnode.Next;
                }

                lastnode .Next = newNode;
            }

            public void Display()
            {
                ListNode currentNode = Head;
                while(currentNode != null)
                {
                    Console.WriteLine(currentNode.Data +"->");
                    currentNode = currentNode.Next;
                }
                Console.WriteLine("null");
            }
        }

        
    }
}
