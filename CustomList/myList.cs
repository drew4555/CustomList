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
        public T[] mylist;
        public T[] mylist2;
        public T[] mylist3;
        public int CountofList { get { return countoflist; } }
        private int countoflist;
        public int capacity { get; set; }
        public myList()
        {       
            capacity = 8;
            mylist = new T[capacity];
            mylist2 = new T[capacity];
            mylist3 = new T[capacity];
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
            string myStringOveride = " ";
            for (int i = 0; i < countoflist; i++)
            {
                myStringOveride += mylist[i].ToString() + ", " ;
            }
            return myStringOveride;
        }
        public static myList<T> operator +(myList<T> mylist, myList<T> mylist2)
        {
            myList<T> newlist = new myList<T>();
            for (int i = 0; i < mylist.countoflist; i++)
            {
                newlist.AddToMyList(mylist[i]);
            }
            for (int i = 0; i < mylist2.countoflist; i++)
            {
                newlist.AddToMyList(mylist2[i]);
            }
            return newlist;
        }
        public static myList<T> operator -(myList<T> mylist, myList<T> mylist2)
        {
            myList<T> newlist = new myList<T>();
            for (int i = 0; i < mylist.countoflist; i++)
            {
                newlist.AddToMyList(mylist[i]);
            }
                foreach (T item in newlist)
                {
                    for(int x=0; x<mylist2.countoflist; x++)
                    {
                        if (item.Equals(mylist2[x]))
                        {
                            newlist.RemoveItemFromList(item);
                            mylist2.RemoveItemFromList(item);
                            for (int b = 0; b < mylist2.countoflist; b++)
                            {
                                newlist.AddToMyList(mylist2[b]);
                            }
                        }
                    }
                    
                }
            return newlist;
        }
            
         public void zipperdeedoodah()
        {
            for (int index = 0; index < mylist.countoflist; index++)
            {

            }
        }   
        public void display()
        {
            Console.WriteLine("{0}", mylist3.ToString());
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
