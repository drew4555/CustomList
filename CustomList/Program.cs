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
            myList<int> andrewsList2 = new myList<int>();
            andrewsList.AddToMyList(3);
            andrewsList2.AddToMyList(6);
            andrewsList.AddToMyList(9);
            andrewsList2.AddToMyList(12);
            andrewsList.AddToMyList(15);
            andrewsList2.AddToMyList(18);
            //andrewsList.RemoveItemFromList(15);
            //andrewsList.RemoveItemFromList(9);
            //Console.WriteLine(andrewsList.ToString());
            //Console.WriteLine(andrewsList2.ToString());
            //Console.ReadKey(); 
        }
        
    }
}
