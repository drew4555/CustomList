using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
       
    {
        static void Main(string[] args)
        {
            myList<int> andrewsList = new myList<int>();
            andrewsList.AddToMyList(3);
            andrewsList.AddToMyList(6);
            andrewsList.AddToMyList(9);
            andrewsList.AddToMyList(12);
            andrewsList.AddToMyList(15);
            andrewsList.AddToMyList(18);

            andrewsList.RemoveItemFromList(15);
        }
    }
}
