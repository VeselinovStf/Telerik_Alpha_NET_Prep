using System;
using System.IO;

namespace MergeTwoLinkedLists
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

        //NOTE: THIS Solution neats fix -> give 1 test others fale
        static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            SinglyLinkedListNode head = null;
            SinglyLinkedListNode current = null;

            var h1Current = head1;
            var h2Current = head2;

            if (h1Current == null)
            {
                return h2Current;
               
            }
            if (h2Current == null)
            {
                return h1Current;                
            }

         
            while (h1Current != null && h2Current != null)
            {
                if (head == null)
                {
                    if (h1Current.data <= h2Current.data)
                    {
                        head = h1Current;
                        current = h1Current;
                        h1Current = h1Current.next;
                    }
                    else
                    {
                        head = h2Current;
                        current = h2Current;
                        h1Current = h2Current.next;
                    }
                }
                else
                {
                    if (h1Current.data <= h2Current.data)
                    {
                        current.next = h1Current;
                        current = h1Current;
                        h1Current = h1Current.next;
                    }
                    else
                    {
                        current.next = h2Current;
                        current = h2Current;
                        h1Current = h2Current.next;
                    }
                }


            }
            if (h1Current != null)
            {
                current.next = h1Current;
            }
            if (h2Current != null)
            {
                current.next = h2Current;
            }
            return head;
        }

        public static void Main()
        {
            TextWriter textWriter = new StreamWriter("test.txt");

            int tests = Convert.ToInt32(Console.ReadLine());

            for (int testsItr = 0; testsItr < tests; testsItr++)
            {
                SinglyLinkedList llist1 = new SinglyLinkedList();

                int llist1Count = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llist1Count; i++)
                {
                    int llist1Item = Convert.ToInt32(Console.ReadLine());
                    llist1.InsertNode(llist1Item);
                }

                SinglyLinkedList llist2 = new SinglyLinkedList();

                int llist2Count = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llist2Count; i++)
                {
                    int llist2Item = Convert.ToInt32(Console.ReadLine());
                    llist2.InsertNode(llist2Item);
                }

                SinglyLinkedListNode llist3 = mergeLists(llist1.head, llist2.head);

                PrintSinglyLinkedList(llist3, " ", textWriter);
                textWriter.WriteLine();
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}