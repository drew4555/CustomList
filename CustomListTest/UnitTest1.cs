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
            actual = andrewsList[0];
            expected = "andrew";

            //Assert
            Assert.AreEqual(expected, actual);

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
            andrewsList.AddToMyList(newNumber);
            actual = andrewsList[0];
            expected = 7;

            //Assert
            Assert.AreEqual(expected, actual);
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
            actual = andrewsList[0];
            expected = 21;

            //assert
            Assert.AreEqual(expected, actual);
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
            actual = andrewsList[1];
            expected = 9;

            //Assert
            Assert.AreEqual(expected, actual);
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
            actual = andrewsList[0];
            expected = "pizza";

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemovingNumberFromMyList_RemoveNumber9FromList_RemoveIndex1FromList()
        {
            //Arrange
            myList<int> andrewsList = new myList<int>();
            int removingNumber = 9;
            int actual;
            int expected;

            //Act
            andrewsList.AddToMyList(7);
            andrewsList.AddToMyList(9);
            andrewsList.RemoveItemFromList(removingNumber);
            expected = 7;
            actual = andrewsList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveStringFromList_RemoveStringAndrewFromList_ListisNowJustStudent()
        {
            //Arrange
            myList<string> andrewsList = new myList<string>();
            string andrew = "andrew";
            string student = "student";
            string actual;
            string expected;

            //Act
            andrewsList.AddToMyList(andrew);
            andrewsList.AddToMyList(student);
            andrewsList.RemoveItemFromList(andrew);
            expected = "student";
            actual = andrewsList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemovingItemFromList_Removingindex3fromList_ListMovesDownAnIndexAt3()
        {
            //Arrange
            myList<double> andrewsList = new myList<double>();
            double twenty = 20;
            double thirty = 30;
            double ten = 10;
            double fourty = 40;
            double fifty = 50;
            double expected;
            double actual;

            //act
            andrewsList.AddToMyList(ten);
            andrewsList.AddToMyList(twenty);
            andrewsList.AddToMyList(thirty);
            andrewsList.AddToMyList(fourty);
            andrewsList.AddToMyList(fifty);
            andrewsList.RemoveItemFromList(thirty);
            expected = fifty;
            actual = andrewsList[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveBoolFromList_RemoveBoolTrue_ListofFalse()
        {
            //Arrange
            bool mine = true;
            bool yours = false;
            bool his = false;
            bool hers = true;
            myList<bool> andrewsList = new myList<bool>();
            bool actual;
            bool expected;

            //act
            andrewsList.AddToMyList(mine);
            andrewsList.AddToMyList(hers);
            andrewsList.AddToMyList(his);
            andrewsList.AddToMyList(yours);
            andrewsList.RemoveItemFromList(mine);
            andrewsList.RemoveItemFromList(hers);
            expected = false;
            actual = andrewsList[0];
            //Assess
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CapacityDoubledWith10ItemsInList_Removing5Items_5ItemsRemainingAndshiftedOver()
        {
            //arrange
             int one = 1;
             int two = 2;
             int three = 3;
             int four = 4;
             int five = 5;
             int six = 6;
             int expected;
             int actual;
            myList<int> andrewsList = new myList<int>();

            //act
            andrewsList.AddToMyList(one);
            andrewsList.AddToMyList(two);
            andrewsList.AddToMyList(three);
            andrewsList.AddToMyList(four);
            andrewsList.AddToMyList(five);
            andrewsList.AddToMyList(five);
            andrewsList.AddToMyList(five);
            andrewsList.AddToMyList(five);
            andrewsList.AddToMyList(five);
            andrewsList.AddToMyList(six);
            andrewsList.RemoveItemFromList(five);
            expected = 6;
            actual = andrewsList[8];

            //Assess
            Assert.AreEqual(expected, actual);
        }
    }
}

        

    



