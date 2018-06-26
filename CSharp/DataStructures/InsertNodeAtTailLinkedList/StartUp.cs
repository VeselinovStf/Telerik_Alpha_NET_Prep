using System;
using System.IO;

namespace InsertNodeAtTailLinkedList
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

            public SinglyLinkedList()
            {
                this.head = null;
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

        private static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        {
            var newNote = new SinglyLinkedListNode(data);
            if (head == null)
            {
                head = newNote;
                return head;
            }
            else
            {
                SinglyLinkedListNode current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNote;
                return head;
            }
        }

        public static void Main()
        {
            TextWriter textWriter = new StreamWriter("test.txt");

            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                SinglyLinkedListNode llist_head = insertNodeAtTail(llist.head, llistItem);
                llist.head = llist_head;
            }

            PrintSinglyLinkedList(llist.head, "\n", textWriter);
            textWriter.WriteLine();

            textWriter.Flush();
            textWriter.Close();
        }
    }
}