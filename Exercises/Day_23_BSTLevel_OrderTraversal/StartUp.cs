using System;
using System.Collections.Generic;

namespace Day_23_BSTLevel_OrderTraversal
{
    public class StartUp
    {
        private static void levelOrder(Node root)
        {
            Queue<Node> nodes = new Queue<Node>();
            nodes.Enqueue(root);
            while (nodes.Count != 0)
            {
                root = nodes.Dequeue();
                Console.Write(root.data + " ");
                if (root.left != null)
                {
                    nodes.Enqueue(root.left);
                }
                if (root.right != null)
                {
                    nodes.Enqueue(root.right);
                }
            }
        }

        public static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        public static void Main()
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);
        }
    }
}