using System;
using System.IO;

namespace DeleteNode_LinkedList
{
    /// <summary>
    /// All classes are in one file ( this is bad practice ), it's done for the ease of exercise 
    /// </summary>
    
    public class StartUp
    {
        class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                }

                this.tail = node;
            }
        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
        {
            while (node != null)
            {
                textWriter.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    textWriter.Write(sep);
                }
            }
        }

        static SinglyLinkedListNode deleteNode(SinglyLinkedListNode head, int position)
        {

            var leftPointer = head;
            var nextPointer = head.next;

            int count = 1;

            if (position == 0)
            {
                head = nextPointer;
            }
            else
            {
                while (count != position)
                {
                    leftPointer = leftPointer.next;
                    nextPointer = nextPointer.next;
                    count++;
                }

                if (nextPointer.next == null)
                {
                    leftPointer.next = null;
                }
                else
                {
                    leftPointer.next = nextPointer.next;
                }
            }

            return head ;
        }

        public static void Main()
        {
            TextWriter textWriter = new StreamWriter("test.txt");

            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            int position = Convert.ToInt32(Console.ReadLine());

            SinglyLinkedListNode llist1 = deleteNode(llist.head, position);

            PrintSinglyLinkedList(llist1, " ", textWriter);
            textWriter.WriteLine();

            textWriter.Flush();
            textWriter.Close();
        }
    }
}