using System;
using System.IO;

namespace InsertingNodeIntoSortedDoublyLinkedList
{
    /// <summary>
    /// All classes are in one file ( this is bad practice ), it's done for the ease of exercise
    /// </summary>
    public class StartUp
    {
        private class DoublyLinkedListNode
        {
            public int data;
            public DoublyLinkedListNode next;
            public DoublyLinkedListNode prev;

            public DoublyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
                this.prev = null;
            }
        }

        private class DoublyLinkedList
        {
            public DoublyLinkedListNode head;
            public DoublyLinkedListNode tail;

            public DoublyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                    node.prev = this.tail;
                }

                this.tail = node;
            }
        }

        private static void PrintDoublyLinkedList(DoublyLinkedListNode node, string sep, TextWriter textWriter)
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

        private static DoublyLinkedListNode sortedInsert(DoublyLinkedListNode head, int data)
        {
            var current = head;
            var newNode = new DoublyLinkedListNode(data);

            if (current == null)
            {
                return newNode;
            }

            if (data <= current.data)
            {
                newNode.next = current;
                current.prev = newNode;
                newNode.prev = null;

                return head = newNode;
            }
            else
            {
                while (current.next != null)
                {
                    if (data <= current.next.data)
                    {
                        //insert in the midle
                        var storeNext = current.next;
                        current.next = newNode;
                        newNode.next = storeNext;
                        storeNext.prev = newNode;

                        return head;
                    }
                    current = current.next;
                }

                //insert at the end
                current.next = newNode;
                newNode.prev = current;
                newNode.next = null;

                return head;
            }
        }

        public static void Main()
        {
            TextWriter textWriter = new StreamWriter("test.txt");

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                DoublyLinkedList llist = new DoublyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                int data = Convert.ToInt32(Console.ReadLine());

                DoublyLinkedListNode llist1 = sortedInsert(llist.head, data);

                PrintDoublyLinkedList(llist1, " ", textWriter);
                textWriter.WriteLine();
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}