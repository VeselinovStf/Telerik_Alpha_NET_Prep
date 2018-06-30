using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeBaseImplementation
{
    public class BinaryTreeNode<T>
    {
        private T value;

        private bool hasParent;

        private BinaryTreeNode<T> leftChild;
        private BinaryTreeNode<T> rightChild;

        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        public BinaryTreeNode<T> LeftChild
        {
            get
            {
                return this.leftChild;
            }
            set
            {
                if (value == null)
                {
                    return;
                }

                if (value.hasParent)
                {
                    throw new ArgumentException("The node already has a parent!");
                }

                this.leftChild = value;
                value.hasParent = true;
            }
        }

        public BinaryTreeNode<T> RightChild
        {
            get
            {
                return this.rightChild;
            }
            set
            {
                if (value == null)
                {
                    return;
                }

                if (value.hasParent)
                {
                    throw new ArgumentException("The node already has a parent!");
                }

                this.rightChild = value;
                value.hasParent = true;
            }
        }

        public BinaryTreeNode(T value,
            BinaryTreeNode<T> leftChild,
            BinaryTreeNode<T> rightChild)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Value can't be null!");
            }

            this.value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        public BinaryTreeNode(T value)
            : this(value, null, null)
        {
        }
    }
}