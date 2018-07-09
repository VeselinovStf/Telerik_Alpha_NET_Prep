using System;

namespace Day_24_MoreLinkedListsRemoveDuplicates
{
    public class StartUp
    {
        public static Node removeDuplicates(Node head)
        {
            Node currentNode = head;
            while (currentNode != null && currentNode.next != null)
            {
                Node node = currentNode;
                while (node.next != null)
                {
                    if (node.next.data == currentNode.data)
                    {
                        Node next = node.next.next;
                        Node temp = node.next;
                        node.next = next;
                        temp = null;
                    }
                    else
                    {
                        node = node.next;
                    }
                }
                currentNode = currentNode.next;
            }

            return head;
        }

        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);

            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;
            }
            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        private static void Main(String[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }
    }
}