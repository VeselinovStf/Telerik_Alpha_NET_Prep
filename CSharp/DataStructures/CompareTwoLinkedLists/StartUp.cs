using System;
using System.IO;

namespace CompareTwoLinkedLists
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

        private static bool CompareLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            bool areSame = false;

            var firstList = head1;
            var secondList = head2;

            while (true)
            {
                if (firstList == null || secondList == null)
                {
                    if (firstList == null && secondList == null)
                    {
                        if (areSame)
                        {
                            return true;
                        }
                    }

                    return false;
                }
                else
                {
                    if (firstList.data != secondList.data)
                    {
                        return false;
                    }
                    else
                    {
                        firstList = firstList.next;
                        secondList = secondList.next;

                        areSame = true;
                    }
                }
            }
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

                bool result = CompareLists(llist1.head, llist2.head);

                textWriter.WriteLine((result ? 1 : 0));
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}