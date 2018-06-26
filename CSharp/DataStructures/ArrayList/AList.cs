using System;

namespace ArrayList
{
    public class AList<T>
    {
        private T[] arr;

        private int count;

        public int Count { get { return this.count; } }

        private const int INITIAL_CAPACITY = 4;

        public AList()
        {
            this.arr = new T[INITIAL_CAPACITY];
            this.count = 0;
        }

        public void Add(T item)
        {
            Insert(count, item);
        }

        public void Insert(int index, T item)
        {
            if (index > this.count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Index was out of boundry");
            }

            if (this.count + 1 > this.arr.Length)
            {
                T[] resizeArr = new T[this.count * 2];
                Array.Copy(arr, resizeArr, arr.Length);
                arr = resizeArr;
            }

            this.arr[index] = item;
            this.count++;
        }

        public void Clear()
        {
            this.arr = new T[INITIAL_CAPACITY];
            this.count = 0;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Contains(T item)
        {
            int indexOf = IndexOf(item);
            bool itContains = (indexOf != -1);
            return itContains;
        }

        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                          "Invalid index: " + index);
                }
                return arr[index];
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                          "Invalid index: " + index);
                }
                this.arr[index] = value;
            }
        }

        public T RemoveAt(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }

            T item = this.arr[index];

            ResizeWhenRemove(index);

            return item;
        }

        private void ResizeWhenRemove(int index)
        {
            T[] temp = new T[count - 1];
            for (int i = 0; i < index; i++)
            {
                temp[i] = arr[i];
            }
            for (int i = index + 1; i < arr.Length; i++)
            {
                temp[i - 1] = arr[i];
            }
            arr = temp;
            count--;
        }

        public int RemoveElement(T element)
        {
            int index = IndexOf(element);
            if (index == -1)
            {
                return index;
            }

            ResizeWhenRemove(index);

            return index;
        }
    }
}