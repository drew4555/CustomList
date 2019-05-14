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
            string myName = "andrew";
            string actual;
            string expected;

            //Act
            andrewsList.AddToMyList(myName);

            //Assert
            Assert.AreEqual(andrewsList[0], myName);

        }
        [TestMethod]
        public void AddedIntValueToList_AddingInt7ToIndex_Added7ToListIndex0()
        {
            //Arrange
            myList<int> andrewsList = new myList<int>();
            int newNumber = 7;
            int actual;
            int expected;

            //Act
            andrewsList.Add(newNumber);

            //Assert
            Assert.AreEqual(andrewsList[0], newNumber);
        }
        [TestMethod]
        public void AddingDoubleToList_AddedDouble21ToString_Added21ToIndex1()
        {
            //arrange
            myList<double> andrewsList = new myList<double>();
            double number = 21;
            double expected;
            double actual;

            //act
            andrewsList.AddToMyList(number);

            //assert
            Assert.AreEqual(andrewsList[0], number);
        }
        [TestMethod]
        public void AddingNewNumberToIndex_AddingInt9toIndex1_Added9ToIndex1()
        {
            //Arrange
            myList<int> andrewsList = new myList<int>();
            int newNumber = 7;
            int newNumber1 = 9;
            int actual;
            int expected;

            //Act
            andrewsList.AddToMyList(newNumber);
            andrewsList.AddToMyList(newNumber1);

            //Assert
            Assert.AreEqual(andrewsList[1], newNumber1);
        }
        [TestMethod]
        public void AddingTwoStringsToList_Adding_pizza_chickenToList_Index2ShouldBeChicken()
        {
            //Arrange
            myList<string> andrewsList = new myList<string>();
            string pizza = "pizza";
            string chicken = "chicken";
            string actual;
            string expected;

            //Act
            andrewsList.AddToMyList(pizza);
            andrewsList.AddToMyList(chicken);

            //Assert
            Assert.AreEqual(andrewsList[1], chicken);

            
        }
        [TestMethod]
        public void RemovingNumberFromMyList_RemoveNumber9FromList_RemoveIndex1FromList()
        {
            //Arrange
            myList<int> andrewsList = new myList<int>(7, 9);
            int removingNumber = 9;
            int actual;
            int expected;
            
            //Act
            andrewsList.RemoveFromList(removingNumber);

            //Assert
            Assert.AreEqual(andrewsList.CountofList, 1);
        }
        [TestMethod]
        public void RemoveStringFromList_RemoveStringAndrewFromList_ListisNowJustStudent()
        {
            //Arrange
            myList<string> andrewsList = new myList<string>(andrew, student);
            string andrew = "andrew";
            string student = "student";
            string actual;
            string expected;

            //
            andrewsList.RemoveFromList(andrew);

            //Assert
            Assert.AreEqual(andrewsList[0], student);
        }
        [TestMethod]
        public void RemovingDoubleFromList_Removing20fromList_ListDoesNotContain20()
        {
            //Arrange
            myList<double> andrewsList = new myList<double>(20, 30);
            double twenty = 20;
            double thirty = 30;
            double expected;
            double actual;

            //act
            andrewsList.RemoveFromList(twenty);

            //Assert
            Assert.AreEqual(andrewsList[0], thirty);
        }
        [TestMethod]
        public void RemoveBoolFromList_RemoveBoolTrue_ListofFalse()
        {
            //Arrange
            bool mine = true;
            bool yours = false;
            myList<bool> andrewsList = new myList<bool>(mine, yours);
            bool actual;
            bool expected;

            //act
            andrewsList.RemoveFromList(mine);

            //Assess
            Assert.AreEqual(andrewsList[0], yours);
            

        }
    }
}
