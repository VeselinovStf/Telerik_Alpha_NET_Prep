using System;
using System.IO;

namespace CycleDetectionInLinkedList
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

        private static bool hasCycle(SinglyLinkedListNode head)
        {
            if (head.next == null)
            {
                return false;
            }

            var pointer = head;
            var nextPointer = head;

            while (nextPointer != null && nextPointer.next != null)
            {
                pointer = pointer.next;
                nextPointer = nextPointer.next.next;

                if (pointer == nextPointer)
                {
                    return true;
                }
            }

            return false;
        }

        public static void Main()
        {
            TextWriter textWriter = new StreamWriter("test.txt");

            int tests = Convert.ToInt32(Console.ReadLine());

            for (int testsItr = 0; testsItr < tests; testsItr++)
            {
                int index = Convert.ToInt32(Console.ReadLine());

                SinglyLinkedList llist = new SinglyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                SinglyLinkedListNode extra = new SinglyLinkedListNode(-1);
                SinglyLinkedListNode temp = llist.head;

                for (int i = 0; i < llistCount; i++)
                {
                    if (i == index)
                    {
                        extra = temp;
                    }

                    if (i != llistCount - 1)
                    {
                        temp = temp.next;
                    }
                }

                temp.next = extra;

                bool result = hasCycle(llist.head);

                textWriter.WriteLine((result ? 1 : 0));
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}