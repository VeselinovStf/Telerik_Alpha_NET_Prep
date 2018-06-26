using System;
using System.IO;

namespace DeleteDuplicateValuesFromSortedLinkedList
{
    /// <summary>
    /// All classes are in one file ( this is bad practice ), it's done for the ease of exercise
    /// </summary>
    public class StartUp
    {
        private class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        private class SinglyLinkedList
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

        private static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
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

        private static SinglyLinkedListNode removeDuplicates(SinglyLinkedListNode head)
        {
            if (head.next == null)
            {
                return head;
            }

            var pointer = head;
            var nextPointer = head.next;

            while (nextPointer != null)
            {
                if (pointer.data == nextPointer.data)
                {
                    if (nextPointer.next == null)
                    {
                        pointer.next = null;
                    }
                    else
                    {
                        while (nextPointer.next != null)
                        {
                            if (nextPointer.next.data > pointer.data)
                            {
                                nextPointer = nextPointer.next;
                                break;
                            }
                            nextPointer = nextPointer.next;
                        }
                        if (pointer.data == nextPointer.data)
                        {
                            pointer.next = null;
                            break;
                        }
                        pointer.next = nextPointer;

                        if (nextPointer.next == null)
                        {
                            return head;
                        }
                    }

                    //nextPointer = nextPointer.next;
                }
                pointer = pointer.next;
                nextPointer = nextPointer.next;
            }

            return head;
        }

        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter("test.txt");

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                SinglyLinkedList llist = new SinglyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                SinglyLinkedListNode llist1 = removeDuplicates(llist.head);

                PrintSinglyLinkedList(llist1, " ", textWriter);
                textWriter.WriteLine();
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}