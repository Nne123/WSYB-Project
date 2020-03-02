using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestFramework
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            // create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create some test data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            // add an item to the list
            // create the item of test data
            clsOrder TestItem = new clsOrder();
            // set its properties
            TestItem.OrderNo = 2;
            TestItem.FirstMenuItem = 3;
            TestItem.SecondMenuItem = 2;
            TestItem.ThirdMenuItem = 1;
            TestItem.FirstPrice = 3;
            TestItem.SecondPrice = 2;
            TestItem.ThirdPrice = 1;
            TestItem.OrderTotal = 6;
            // add the item to the list
            TestList.Add(TestItem);
            // assign the data to the property
            AllOrders.OrderList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    clsOrderCollection AllOrders = new clsOrderCollection();
        //    Int32 SomeCount = 1;
        //    AllOrders.Count = SomeCount;
        //    Assert.AreEqual(AllOrders.Count, SomeCount);
        //}

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            // set the properties of the test object
            TestOrder.OrderNo = 2;
            TestOrder.FirstMenuItem = 3;
            TestOrder.SecondMenuItem = 2;
            TestOrder.ThirdMenuItem = 1;
            TestOrder.FirstPrice = 3;
            TestOrder.SecondPrice = 2;
            TestOrder.ThirdPrice = 1;
            TestOrder.OrderTotal = 6;
            // assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            // test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderNo = 2;
            TestItem.FirstMenuItem = 3;
            TestItem.SecondMenuItem = 2;
            TestItem.ThirdMenuItem = 1;
            TestItem.FirstPrice = 3;
            TestItem.SecondPrice = 2;
            TestItem.ThirdPrice = 1;
            TestItem.OrderTotal = 6;
            // add the item to the list
            TestList.Add(TestItem);
            // assign the data to the property
            AllOrders.OrderList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        //[TestMethod]
        //public void TwoOrdersPresentOK()
        //{
        //    clsOrderCollection AllOrders = new clsOrderCollection();
        //    Assert.AreEqual(AllOrders.Count, 2);
        //}

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.OrderNo = 1;
            TestItem.FirstMenuItem = 3;
            TestItem.SecondMenuItem = 2;
            TestItem.ThirdMenuItem = 1;
            TestItem.FirstPrice = 1;
            TestItem.SecondPrice = 3;
            TestItem.ThirdPrice = 4;
            TestItem.OrderTotal = 8;
            // set this order to the test data
            AllOrders.ThisOrder = TestItem;
            // add the record
            PrimaryKey = AllOrders.Add();
            // set the primary key of the test data
            TestItem.OrderNo = PrimaryKey;
            // find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

    }
}
