using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicList
{
    public class SingleLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int count;

        public SingleLinkedList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void Add(T item)
        {
            if (head == null)
            {
                head = new Node<T>(item);
                tail = head;
            }
            else
            {
                Node<T> newNode = new Node<T>(item, tail);
                tail = newNode;
            }
        }

        public T Remove(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index");
            }

            int currentIndex = 0;
            Node<T> currentNode = head;
            Node<T> prevNode = null;

            while (currentIndex < index)
            {
                prevNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }

            count--;
            if (count == null)
            {
                head = null;
            }
            else if (prevNode == null)
            {
                head = currentNode.Next;
            }
            else
            {
                prevNode.Next = currentNode.Next;
            }

            Node<T> lastElement = null;
            if (this.head != null)
            {
                lastElement = this.head;
                while (lastElement.Next != null)
                {
                    lastElement = lastElement.Next;
                }
            }
            tail = lastElement;

            return currentNode.Element;
        }

        private class Node<T>
        {
            private T element;
            private Node<T> next;


            public Node(T element)
            {
                this.element = element;
                this.next = null;
            }

            public Node(T element, Node<T> prevElement)
            {
                this.element = element;
                prevElement.next = this;
            }

            public T Element { get => element; set => element = value; }
            public Node<T> Next { get => next; set => next = value; }
        }
    }
}
