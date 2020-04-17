using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFramework
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderNoPropertyOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnOrder.OrderNo = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }

        [TestMethod]
        public void FirstChoiceOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnOrder.FirstChoice = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.FirstChoice, TestData);
        }

        [TestMethod]
        public void SecondChoiceOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Int32 TestData = 2;
            // assign the data to the property
            AnOrder.SecondChoice = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.SecondChoice, TestData);
        }

        [TestMethod]
        public void ThirdChoiceOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Int32 TestData = 3;
            // assign the data to the property
            AnOrder.ThirdChoice = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.ThirdChoice, TestData);
        }


        [TestMethod]
        public void FirstPriceOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnOrder.FirstPrice = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.FirstPrice, TestData);
        }

        [TestMethod]
        public void SecondPriceOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Int32 TestData = 2;
            // assign the data to the property
            AnOrder.SecondPrice = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.SecondPrice, TestData);
        }

        [TestMethod]
        public void ThirdPriceOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Int32 TestData = 3;
            // assign the data to the property
            AnOrder.ThirdPrice = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.ThirdPrice, TestData);
        }

        [TestMethod]
        public void OrderTotalOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Int32 TestData = 6;
            // assign the data to the property
            AnOrder.OrderTotal = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderTotal, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Boolean Found = false;
            // create some test data to use with the method
            Int32 OrderNo = 1;
            // invoke the method
            Found = AnOrder.Find(OrderNo);
            // test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderNoFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderNo = 1;
            // invoke the method
            Found = AnOrder.Find(OrderNo);
            // check the order no
            if (AnOrder.OrderNo != 1)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstChoiceFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderNo = 1;
            // invoke the method
            Found = AnOrder.Find(OrderNo);
            // check the first menu item
            if (AnOrder.FirstChoice != 1)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSecondChoiceFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderNo = 1;
            // invoke the method
            Found = AnOrder.Find(OrderNo);
            // check the second menu item
            if (AnOrder.SecondChoice != 2)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestThirdChoiceFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderNo = 1;
            // invoke the method
            Found = AnOrder.Find(OrderNo);
            // check the third menu item
            if (AnOrder.ThirdChoice != 3)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstPriceFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderNo = 1;
            // invoke the method
            Found = AnOrder.Find(OrderNo);
            // check the first price
            if (AnOrder.FirstPrice != 3)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSecondPriceFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderNo = 1;
            // invoke the method
            Found = AnOrder.Find(OrderNo);
            // check the second price
            if (AnOrder.SecondPrice != 2)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestThirdPriceFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderNo = 1;
            // invoke the method
            Found = AnOrder.Find(OrderNo);
            // check the third price
            if (AnOrder.ThirdPrice != 1)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderTotalFound()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Boolean Found = false;
            // boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 OrderNo = 1;
            // invoke the method
            Found = AnOrder.Find(OrderNo);
            // check the order total
            if (AnOrder.OrderTotal != 6)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        // good test data
        // create some test data to pass to the method
        string FirstPrice = Convert.ToString(3);
        string SecondPrice = Convert.ToString(4);
        string ThirdPrice = Convert.ToString(5);
        string OrderTotal = Convert.ToString(12);

        [TestMethod]
        public void ValidMethodOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            String Error = "";
            // invoke the method
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstChoiceMinLessOneOK()     
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 0;
            string FirstPrice = TestPrice.ToString();
            // invoke the method
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstChoiceMinBoundaryOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 1;
            string FirstPrice = TestPrice.ToString();
            // invoke the method
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FirstChoiceMinPlusOneOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 2;
            string FirstPrice = TestPrice.ToString();
            // invoke the method
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FirstChoiceMaxLessOneOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 9;
            string FirstPrice = TestPrice.ToString();
            // invoke the method
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FirstChoiceMaxBoundaryOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 10;
            string FirstPrice = TestPrice.ToString();
            // invoke the method
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FirstChoiceMaxPlusOneOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 11;
            string FirstPrice = TestPrice.ToString();
            // invoke the method
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SecondChoiceMinLessOneOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 0;
            string SecondPrice = TestPrice.ToString();
            // invoke the method
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SecondChoiceMinBoundaryOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 1;
            string SecondPrice = TestPrice.ToString();
            // invoke the method
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SecondChoiceMinPlusOneOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 2;
            string SecondPrice = TestPrice.ToString();
            // invoke the method
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SecondChoiceMaxLessOneOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 9;
            string SecondPrice = TestPrice.ToString();
            // invoke the method
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SecondChoiceMaxBoundaryOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 10;
            string SecondPrice = TestPrice.ToString();
            // invoke the method
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SecondChoiceMaxPlusOneOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 11;
            string SecondPrice = TestPrice.ToString();
            // invoke the method
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ThirdChoiceMinLessOneOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 0;
            string ThirdPrice = TestPrice.ToString();
            // invoke the method
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ThirdChoiceMinBoundaryOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 1;
            string ThirdPrice = TestPrice.ToString();
            // invoke the method
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ThirdChoiceMinPlusOneOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 2;
            string ThirdPrice = TestPrice.ToString();
            // invoke the method
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ThirdChoiceMaxLessOneOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 9;
            string ThirdPrice = TestPrice.ToString();
            // invoke the method
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ThirdChoiceMaxBoundaryOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 10;
            string ThirdPrice = TestPrice.ToString();
            // invoke the method
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ThirdChoiceMaxPlusOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 11;
            string ThirdPrice = TestPrice.ToString();
            // invoke the method
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void FirstChoiceInvalidData()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string FirstPrice = "This is not a price!";
            string SecondPrice = Convert.ToString(1);
            string ThirdPrice = Convert.ToString(2);
            string OrderTotal = Convert.ToString(7);
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            Assert.AreNotEqual(Error, "");          
        }

        [TestMethod]
        public void SecondChoiceInvalidData()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string FirstPrice = Convert.ToString(1);
            string SecondPrice = "This is not a price!";
            string ThirdPrice = Convert.ToString(2);
            string OrderTotal = Convert.ToString(7);
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ThirdChoiceInvalidData()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string FirstPrice = Convert.ToString(1);
            string SecondPrice = Convert.ToString(2);
            string ThirdPrice = "This is not a price!";
            string OrderTotal = Convert.ToString(7);
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotlaInvalidData()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string FirstPrice = Convert.ToString(1);
            string SecondPrice = Convert.ToString(7);
            string ThirdPrice = Convert.ToString(2);
            string OrderTotal = "This is not a price!";
            Error = AnOrder.Valid(FirstPrice, SecondPrice, ThirdPrice, OrderTotal);
            Assert.AreNotEqual(Error, "");
        }
    }
}
