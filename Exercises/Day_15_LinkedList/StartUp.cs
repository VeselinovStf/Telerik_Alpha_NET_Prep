using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_LinkedList
{
    public class StartUp
    {
        public static Node insert(Node head, int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                return head = newNode;
            }

            var current = head;
            while (current != null)
            {
                if (current.next == null)
                {
                    current.next = newNode;
                    break;
                }
                
                    current = current.next;               
               
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

        public static void Main()
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }
    }
}
