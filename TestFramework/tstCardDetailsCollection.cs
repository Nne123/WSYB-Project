using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestFramework
{
    [TestClass]
    public class tstCardDetailsCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class
            clsCardDetailsCollection AllCardDetails = new clsCardDetailsCollection();
            // test to see that it exists
            Assert.IsNotNull(AllCardDetails);
        }

        [TestMethod]
        public void CardDetailsListOK()
        {
            // create an instance of the class
            clsCardDetailsCollection AllCardDetails = new clsCardDetailsCollection();

            List<clsCardDetails> TestList = new List<clsCardDetails>();

            // create the item of the test data
            clsCardDetails TestItem = new clsCardDetails();
            // set its properties
            TestItem.CardNo = 1;
            TestItem.CardNo1 = "123456";
            // add item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllCardDetails.CardDetailsList = TestList;
            // test to see that it exists
            Assert.AreEqual(AllCardDetails.CardDetailsList, TestList);
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    // create an instance of the class
        //    clsCardDetailsCollection AllCardDetails = new clsCardDetailsCollection();
        //    // create some test data
        //    Int32 SomeCount = 2;
        //    // assign the data to the property
        //    AllCardDetails.Count = SomeCount; 
        //    // test to see that it exists
        //    Assert.AreEqual(AllCardDetails.Count, SomeCount);
        //}

        [TestMethod]
        public void ThisCardDetailsPropertyOK()
        {
            // create an instance of the class
            clsCardDetailsCollection AllCardDetails = new clsCardDetailsCollection();
            // create the item of the test data
            clsCardDetails TestCardDetails = new clsCardDetails();
            // set its properties
            TestCardDetails.CardNo = 1;
            TestCardDetails.CardNo1 = "123456";
            // assign the data to the property
            AllCardDetails.ThisCardDetails = TestCardDetails;
            // test to see that it exists
            Assert.AreEqual(AllCardDetails.ThisCardDetails, TestCardDetails);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class
            clsCardDetailsCollection AllCardDetails = new clsCardDetailsCollection();
            // create some test data to assign to the property
            // in this case the data to be a list of objects
            List<clsCardDetails> TestList = new List<clsCardDetails>();
            // create the item of the test data
            clsCardDetails TestItem = new clsCardDetails();
            // set its properties
            TestItem.CardNo = 1;
            TestItem.CardNo1 = "123456";
            // assign the data to the property
            TestList.Add(TestItem);
            // assign the data to the property
            AllCardDetails.CardDetailsList = TestList;
            // test to see that it exists
            Assert.AreEqual(AllCardDetails.Count, TestList.Count);
        }


        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    // create an instance of the class
        //    clsCardDetailsCollection AllCardDetails = new clsCardDetailsCollection();
        //    // test to see that it exists
        //    Assert.AreEqual(AllCardDetails.Count, 2);
        //}


    }
}
