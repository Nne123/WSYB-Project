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
        public void FirstMenuItemOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnOrder.FirstMenuItem = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.FirstMenuItem, TestData);
        }

        [TestMethod]
        public void SecondMenuItemOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Int32 TestData = 2;
            // assign the data to the property
            AnOrder.SecondMenuItem = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.SecondMenuItem, TestData);
        }

        [TestMethod]
        public void ThirdtMenuItemOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Int32 TestData = 3;
            // assign the data to the property
            AnOrder.ThirdMenuItem = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnOrder.ThirdMenuItem, TestData);
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
        public void TestFirstMenuItemFound()
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
            if (AnOrder.FirstMenuItem != 1)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSecondMenuItemFound()
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
            if (AnOrder.SecondMenuItem != 2)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestThirdMenuItemFound()
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
            if (AnOrder.ThirdMenuItem != 3)
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

        [TestMethod]
        public void ValidMethodOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            String Error = "";
            // invoke the method
            Error = AnOrder.Valid();
            Assert.AreEqual(Error, "");
        }
    }
}
