using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestFramework
{
    [TestClass]
    public class tstMenuItemCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsMenuItemCollection AllMenuItems = new clsMenuItemCollection();
            Assert.IsNotNull(AllMenuItems);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsMenuItemCollection AllMenuItems = new clsMenuItemCollection();
            Int32 SomeCount = 3;
            AllMenuItems.Count = SomeCount;
            Assert.AreEqual(AllMenuItems.Count, SomeCount);
        }

        [TestMethod]
        public void AllMenuItemsOK()
        {
            clsMenuItemCollection MenuItems = new clsMenuItemCollection();
            List<clsMenuItem> TestList = new List<clsMenuItem>();
            clsMenuItem TestItem = new clsMenuItem();
            TestItem.MenuItemNo = 1;
            TestItem.MenuItem = "Grapes";
            TestItem.MenuItemPrice = 4;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            MenuItems.AllMenuItems = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(MenuItems.AllMenuItems, TestList);
        }

        [TestMethod]
        public void CountMatchesListOK()
        {
            clsMenuItemCollection MenuItems = new clsMenuItemCollection();
            List<clsMenuItem> TestList = new List<clsMenuItem>();
            clsMenuItem TestItem = new clsMenuItem();
            TestItem.MenuItemNo = 1;
            TestItem.MenuItem = "Grapes";
            TestItem.MenuItemPrice = 4;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            MenuItems.AllMenuItems = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(MenuItems.Count, TestList.Count);
        }


        //[TestMethod]
        //public void TwoMenuItemsPresent()
        //{
        //    clsMenuItemCollection MenuItems = new clsMenuItemCollection();
        //    Assert.AreEqual(MenuItems.Count, 2);
        //}
    }
}
