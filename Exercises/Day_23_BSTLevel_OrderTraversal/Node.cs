﻿namespace Day_23_BSTLevel_OrderTraversal
{
    public class Node
    {
        public Node left, right;
        public int data;

        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
}