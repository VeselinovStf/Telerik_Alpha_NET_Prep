﻿using System;
using System.IO;

namespace ReverseDoublyLinkedList
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

        private static DoublyLinkedListNode reverse(DoublyLinkedListNode head)
        {
            var current = head;
            var newHead = head;

            while (current != null)
            {
                var temp = current.prev;
                current.prev = current.next;
                current.next = temp;
                newHead = current;

                current = current.prev;
            }

            return newHead;
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

                DoublyLinkedListNode llist1 = reverse(llist.head);

                PrintDoublyLinkedList(llist1, " ", textWriter);
                textWriter.WriteLine();
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}