using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class myList<T> : IEnumerable <T>
    {

        T[] mylist;
        public int CountofList { get { return countoflist; } }
        private int countoflist;
        public int capacity { get; set; }
        public myList()
        {
            capacity = 4;
            mylist = new T[capacity];
            countoflist = 0;
        }
        public T this[int i]
        {
            get { return mylist[i]; }
            set { mylist[i] = value; }
        }

        public void AddToMyList(T item)
        {
            mylist[countoflist] = item;
            countoflist++;
            EnsureCapacity();
        }
        private void EnsureCapacity()
        {
            if (countoflist == capacity)
            {
                capacity = capacity * 2;
                T[] newArray = new T[capacity];
                for (int b = 0; b < countoflist; b++)
                {
                    newArray[b] = mylist[b];
                }
                mylist = newArray;
            }
        }
        private int SearchThroughList(T item)
        {
            for (int a = 0; a < countoflist; a++)
            {
                if (mylist[a].Equals(item))
                {
                    return a;
                }
            }
            return -1;
        }
        public void RemoveItemFromList(T item)
        {
            int indexlocation = SearchThroughList(item);
            if (indexlocation != -1)
            {
                T[] newArray = new T[capacity];
                for (int c = 0; c < countoflist; c++)
                {

                    if (indexlocation <= c)
                    {
                        newArray[c] = mylist[c + 1];
                    }
                    else
                    {
                        newArray[c] = mylist[c];
                    }
                }
                mylist = newArray;
                countoflist--;

            }
        }
        public override string ToString()
        {
            for (int i = 0; i < countoflist; i++)
            {
                
                

           

            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)mylist).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
