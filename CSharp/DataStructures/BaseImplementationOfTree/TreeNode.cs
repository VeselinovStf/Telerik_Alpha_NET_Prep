using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseImplementationOfTree
{
    public class TreeNode<T>
    {
        private T value;

        private bool hasParent;

        private List<TreeNode<T>> childrens;

        public TreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentException("Value can't be null!");
            }
            this.Value = value;
            this.childrens = new List<TreeNode<T>>();
        }

        public T Value { get => value; set => this.value = value; }

        public int ChildrenCount
        {
            get
            {
                return this.childrens.Count;
            }
        }

        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentException("Value can't be null!");
            }

            if (child.hasParent)
            {
                throw new ArgumentException("The node already has a parent!");
            }

            child.hasParent = true;
            this.childrens.Add(child);
        }

        public TreeNode<T> GetChild(int index)
        {
            return this.childrens[index];
        }
    }
}