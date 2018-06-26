using System;
using System.IO;

namespace GetNodeValueLinkedList
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

        private static int getNode(SinglyLinkedListNode head, int positionFromTail)
        {
            var totalSize = 0;

            var current = head;
            while (current != null)
            {
                totalSize++;
                current = current.next;
            }

            var elementIndex = totalSize - positionFromTail - 1;
            if (elementIndex == 0)
            {
                return head.data;
            }
            else
            {
                var count = 0;
                var next = head;
                while (count < elementIndex)
                {
                    count++;
                    next = next.next;
                }
                return next.data;
            }
        }

        public static void Main()
        {
            TextWriter textWriter = new StreamWriter("test.txt");

            int tests = Convert.ToInt32(Console.ReadLine());

            for (int testsItr = 0; testsItr < tests; testsItr++)
            {
                SinglyLinkedList llist = new SinglyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                int position = Convert.ToInt32(Console.ReadLine());

                int result = getNode(llist.head, position);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}