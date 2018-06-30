using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeBaseImplementation
{
    public class BinaryTree<T>
    {
        private BinaryTreeNode<T> root;

        public BinaryTree(T value,
            BinaryTree<T> leftChild,
            BinaryTree<T> rightChild)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Value can't be null!");
            }

            BinaryTreeNode<T> leftChildNode =
                leftChild != null ? leftChild.root : null;

            BinaryTreeNode<T> rightChildNode =
                rightChild != null ? rightChild.root : null;

            this.root = new BinaryTreeNode<T>(value, leftChildNode, rightChildNode);
        }

        public BinaryTree(T value)
            : this(value, null, null)
        {
        }

        public BinaryTreeNode<T> Root { get => root; }

        private void PrintInOrder(BinaryTreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }

            PrintInOrder(root.LeftChild);

            Console.WriteLine(root.Value + " ");

            PrintInOrder(root.RightChild);
        }

        public void PrintInOrder()
        {
            PrintInOrder(this.root);
            Console.WriteLine();
        }
    }
}