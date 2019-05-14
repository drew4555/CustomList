using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddStringValueToIndex_AddStringAndrewtoindex_AddedAndrewToListIndex0()
        {
            //Arrange
            myList<string> andrewsList = new myList<string>();
            string myName = andrew;

            //Act
            andrewsList.Add(myName);

            //Assert
            Assert.AreEqual(myName, andrewsList[0]);

        }
        [TestMethod]
        public void AddedIntValueToIndex_AddingInt7ToIndex_Added7ToListIndex0()
        {
            //Arrange
            myList<int> andrewsList = new myList<int>();
            int newNumber = 7;

            //Act
            andrewsList.Add(newNumber);

            //Assert
            Assert.AreEqual(newNumber, andrewsList[0]);
        }
        [TestMethod]
        public void AddingNewNumberToIndex_AddingInt9toIndex1_Added9ToIndex1()
        {
            //Arrange
            myList<int> andrewsList = new myList<int>();
            int newNumber = 7;
            int newNumber1 = 9;

            //Act
            andrewsList.Add(newNumber);
            andrewsList.Add(newNumber1);

            //Assert
            Assert.AreEqual(newNumber1, myList[1]);
        }
        [TestMethod]
        public void RemovingNumberFromMyList_RemoveNumber9FromList_RemoveIndex1FromList()
        {
            //Arrange
            myList<int> andrewsList = new myList<int>(7, 9);
            int removingNumber = 9;
            
            //Act
            andrewsList.RemoveFromList(removingNumber);

            //Assert
        }
    }
}
