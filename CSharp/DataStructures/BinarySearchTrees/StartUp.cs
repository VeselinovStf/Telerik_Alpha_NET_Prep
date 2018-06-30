using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTrees
{
    //  The height of a binary search tree is the number of edges between the tree's root
    //   and its furthest leaf. You are given a pointer, , pointing to the root of a
    //   binary search tree. Complete the getHeight function provided in your editor
    //   so that it returns the height of the binary search tree.

    public class StartUp
    {
        public static int getHeight(Node root)
        {
            if (root == null)
            {
                return -1;
            }
            else
            {
                int leftHeight = getHeight(root.left);
                int rightHeight = getHeight(root.right);

                return (1 + Math.Max(leftHeight, rightHeight));
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
            while (T > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
                T--;
            }
            int height = getHeight(root);
            Console.WriteLine(height);
        }
    }
}