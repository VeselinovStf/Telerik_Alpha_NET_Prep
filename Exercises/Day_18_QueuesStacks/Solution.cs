using System.Collections.Generic;

namespace Day_18_QueuesStacks
{
    public class Solution
    {
        private Stack<char> s;
        private Queue<char> q;

        public Solution()
        {
            this.s = new Stack<char>();
            this.q = new Queue<char>();
        }

        public void pushCharacter(char ch)
        {
            this.s.Push(ch);
        }

        public void enqueueCharacter(char ch)
        {
            this.q.Enqueue(ch);
        }

        public char popCharacter()
        {
            return this.s.Pop();
        }

        public char dequeueCharacter()
        {
            return this.q.Dequeue();
        }
    }
}