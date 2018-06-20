using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class List<T>
    {
        private T[] buffer;
        private int size;
        private const int INITIAL_SIZE = 4;

        public List()
        {
            this.size = 0;
           
            this.buffer = new T[INITIAL_SIZE];
        }

        public void Add(T item)
        {
            if (size == this.buffer.Length)
            {
                Resize(size * 2);
            }
            this.buffer[size] = item;
            size++;
        }

        private void Resize(int v)
        {
            T[] newList = new T[v];
            //for (int i = 0; i < this.buffer.Length; i++)
            //{
            //    newList[i] = this.buffer[i];
            //}
            Array.Copy(this.buffer, newList, this.buffer.Length);
            this.buffer = newList;
        }
    }
}
