using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseImplementationOfTree
{
    public class Tree<T>
    {
        private TreeNode<T> root;

        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentException("Value can't be null!");
            }

            this.root = new TreeNode<T>(value);
        }

        public Tree(T value, params Tree<T>[] children)
            : this(value)
        {
            foreach (Tree<T> child in children)
            {
                this.root.AddChild(child.Root);
            }
        }

        public TreeNode<T> Root { get => root; }

        private void PrintDFS(TreeNode<T> root, string spaces)
        {
            if (this.root == null)
            {
                return;
            }

            Console.WriteLine(spaces + root.Value);

            TreeNode<T> child = null;

            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);

                PrintDFS(child, spaces + "   ");
            }
        }

        public void PrintDFS()
        {
            this.PrintDFS(this.root, string.Empty);
        }
    }
}