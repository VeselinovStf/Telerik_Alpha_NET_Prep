using System;
using System.Text;

namespace GenericLIstExercise
{
    public class GenericListT<T> 
    {
        private static readonly int INITIAL_CAPACITY = 4;
        private T[] arr;
        private int count;

        public GenericListT()
        {
            this.arr = new T[INITIAL_CAPACITY];
            this.count = 0;
        }

        public GenericListT(int capacity)
        {
            if (capacity < 4)
            {
                this.arr = new T[INITIAL_CAPACITY];
            }
            else
            {
                this.arr = new T[capacity];
            }
        }

        public int Count { get => count;}

        public int Capacity
        {
            get
            {
                return this.arr.Length;
            }
            
        }

        public void Add(T item)
        {
            Insert(count, item);
        }

        public void Insert(int index, T item)
        {
            if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid index: " + index);
            }

            T[] newExtendedArr = arr;
            if (count + 1 == arr.Length)
            {
                newExtendedArr = new T[arr.Length * 2];
            }

            Array.Copy(arr, newExtendedArr, index);
            count++;
            arr[index] = item;
            Array.Copy(arr, index, newExtendedArr, index + 1, count - index - 1);
            newExtendedArr[index] = item;
            arr = newExtendedArr;
            
        }

        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Index out of range: " + index);
                }
                return this.arr[index];
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Index out of range: " + index);
                }
                this.arr[index] = value;
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (item.Equals(arr[i]))
                {
                    return i;
                }
            }

            return -1;
        }


        public bool Contains(T item)
        {
            int indexOf = IndexOf(item);
            bool result = (indexOf != -1);
            return result;
        }

        public void Clear()
        {
            this.arr = new T[INITIAL_CAPACITY];
            this.count = 0;
        }

        public T Remove(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Index out of range: " + index);
            }
            T item = arr[index];
            Array.Copy(arr, index + 1, arr, index, count - index);

            arr[count - 1] = default(T);
            count--;
            return item;

        }

        public int Remove(T item)
        {
            int index = IndexOf(item);
            if (index == -1)
            {
                return index;
            }
            Array.Copy(arr, index + 1, arr, index, count - index + 1);
            count--;
            return index;
        }

        public override string ToString()
        {
            //Simple return
            return string.Join(" ", arr);
        }
    }
}
