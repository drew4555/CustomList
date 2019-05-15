using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class myList<T>
    {

        T[] items;
        public int CountofList { get { return countoflist; } }
        private int i;
        private int countoflist;
        public int capacity { get; set; }
        public myList()
        {
            capacity = 4;
            items = new T[capacity];
            i = 0;

        }
        public T this[int i]

        {
            get { return items[i]; }
            set { items[i] = value; }
        }

        public void AddToMyList(T item)
        {
            EnsureCapacity();
            items[i] = item;
            countoflist++;
            i++;
        }
        public void EnsureCapacity()
        {
            if (countoflist == capacity)
            {
                capacity = capacity * 2;
                T[] newArray = new T[capacity];
                for (int b = 0; b < countoflist; b++)
                {
                    newArray[b] = items[b];
                }
                items = newArray;
            }
        }
    }
}
