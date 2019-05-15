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
        //[TestMethod]
        //public void RemovingNumberFromMyList_RemoveNumber9FromList_RemoveIndex1FromList()
        //{
        //    Arrange
        //    myList<int> andrewsList = new myList<int>();
        //    int removingNumber = 9;
        //    int actual;
        //    int expected;

        //    Act
        //    andrewsList.AddToList(7);
        //    andrewsList.AddToList(9);
        //    andrewsList.RemoveFromList(removingNumber);
        //    expected = 7;
        //    actual = andrewsList[0];

        //    Assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void RemoveStringFromList_RemoveStringAndrewFromList_ListisNowJustStudent()
        //{
        //    Arrange
        //    myList<string> andrewsList = new myList<string>();
        //    string andrew = "andrew";
        //    string student = "student";
        //    string actual;
        //    string expected;

        //    Act
        //    andrewsList.AddToList(andrew);
        //    andrewsList.AddToList(student);
        //    andrewsList.RemoveFromList(andrew);
        //    expected = andrewsList[0];
        //    actual = student;

        //    Assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void RemovingDoubleFromList_Removing20fromList_ListDoesNotContain20()
        //{
        //    Arrange
        //    myList<double> andrewsList = new myList<double>();
        //    double twenty = 20;
        //    double thirty = 30;
        //    double expected;
        //    double actual;

        //    act
        //    andrewsList.AddToList(twenty);
        //    andrewsList.AddToList(thirty);
        //    andrewsList.RemoveFromList(twenty);
        //    expected = thirty;
        //    actual = andrewsList[0];

        //    Assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void RemoveBoolFromList_RemoveBoolTrue_ListofFalse()
        //{
        //    Arrange
        //    bool mine = true;
        //    bool yours = false;
        //    myList<bool> andrewsList = new myList<bool>();
        //    bool actual;
        //    bool expected;

        //    act
        //    andrewsList.AddToList(mine);
        //    andrewsList.AddToList(yours);
        //    andrewsList.RemoveFromList(mine);
        //    expected = false;
        //    actual = andrewsList[0];
        //    Assess
        //    Assert.AreEqual(expected, actual);


        //}
    }
}
