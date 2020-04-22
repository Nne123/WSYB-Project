using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFramework
{
    [TestClass]
    public class tstCardDetails
    {

        string CardNo1 = "584756";


        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class 
            clsCardDetails ACardDetail = new clsCardDetails();
            // test to see that it exists
            Assert.IsNotNull(ACardDetail);
        }

        [TestMethod]
        public void CardNo1PropertyOK()
        {
            // create an instance of the class we want to create
            clsCardDetails ACardDetail = new clsCardDetails();
            // create some test data to assign to the property
            string TestData = "756483";
            // assign the data to the property
            ACardDetail.CardNo1 = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(ACardDetail.CardNo1, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            // create an instance of the class we want to create
            clsCardDetails ACardDetail = new clsCardDetails();
            // boolean variable to store the use with the method
            Boolean Found = false;
            // create some test data to use with the method
            Int32 CardNo = 1;
            // invoke the method 
            Found = ACardDetail.Find(CardNo);
            // test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCardNoFound()
        {
            // create an instance of the class we want to create
            clsCardDetails ACardDetail = new clsCardDetails();
            // create some test data to assign to the property
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 CardNo = 1;
            // invoke the method
            Found = ACardDetail.Find(CardNo);
            // check the order no
            if (ACardDetail.CardNo != 1)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCardNo1Found()
        {
            // create an instance of the class we want to create
            clsCardDetails ACardDetail = new clsCardDetails();
            // create some test data to assign to the property
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 CardNo = 1;
            // invoke the method
            Found = ACardDetail.Find(CardNo);
            // check the order no
            if (ACardDetail.CardNo1 != "123456")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }


      


        [TestMethod]
        public void ValidMethodOK()
        {
            clsCardDetails ACardDetail = new clsCardDetails();
            String Error = "";
            Error = ACardDetail.Valid(CardNo1);
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void CardNo1MinLessOne() // 4 char
        {
            clsCardDetails ACardDetail = new clsCardDetails();
            String Error = "";
            string CardNo1 = "1234";
            Error = ACardDetail.Valid(CardNo1);
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void CardNo1MinBoundary() // 5 char
        {
            clsCardDetails ACardDetail = new clsCardDetails();
            String Error = "";
            string CardNo1 = "12345";
            Error = ACardDetail.Valid(CardNo1);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardNo1MinPlusOne() // 6 char
        {
            clsCardDetails ACardDetail = new clsCardDetails();
            String Error = "";
            string CardNo1 = "123456";
            Error = ACardDetail.Valid(CardNo1);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardNo1MaxLessOne() // 9 char
        {
            clsCardDetails ACardDetail = new clsCardDetails();
            String Error = "";
            string CardNo1 = "123456789";
            Error = ACardDetail.Valid(CardNo1);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardNo1MaxBoundary() // 10 char
        {
            clsCardDetails ACardDetail = new clsCardDetails();
            String Error = "";
            string CardNo1 = "12345";
            Error = ACardDetail.Valid(CardNo1);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardNo1MaxPlusOne() // 11 char
        {
            clsCardDetails ACardDetail = new clsCardDetails();
            String Error = "";
            string CardNo1 = "12345678912";
            Error = ACardDetail.Valid(CardNo1);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CardNo1Mid() // 8 char
        {
            clsCardDetails ACardDetail = new clsCardDetails();
            String Error = "";
            string CardNo1 = "12345678";
            Error = ACardDetail.Valid(CardNo1);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardNo1ExtremeMax() // 8 char
        {
            clsCardDetails ACardDetail = new clsCardDetails();
            String Error = "";
            string CardNo1 = "";
            CardNo1 = CardNo1.PadRight(100, 'a');
            Error = ACardDetail.Valid(CardNo1);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CardNoInvalidData() // invalid data
        {
            clsCardDetails ACardDetail = new clsCardDetails();
            String Error = "";
            string CardNo1 = "this is not a card number";
            Error = ACardDetail.Valid(CardNo1);
            Assert.AreNotEqual(Error, "");
        }
    }
}
