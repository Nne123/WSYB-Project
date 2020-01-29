using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace TestFramework
{
    [TestClass]
    public class tstMenuCollection
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
            Int32 SomeCount = 2;
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
            TestItem.MenuItem = "Strawberry";
            TestList.Add(TestItem);
            MenuItems.AllMenuItems = TestList;
            Assert.AreEqual(MenuItems.AllMenuItems, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            clsMenuItemCollection MenuItems = new clsMenuItemCollection();
            List<clsMenuItem> TestList = new List<clsMenuItem>();
            clsMenuItem TestItem = new clsMenuItem();
            TestItem.MenuItemNo = 1;
            TestItem.MenuItem = "Strawberry";
            TestList.Add(TestItem);
            MenuItems.AllMenuItems = TestList;
            Assert.AreEqual(MenuItems.AllMenuItems, TestList);
        }

        [TestMethod]
        public void TwoMenuItemsPresent()
        {
            clsMenuItemCollection MenuItems = new clsMenuItemCollection();
            // are there two records?
            Assert.AreEqual(MenuItems.Count, 2);
        }
    }
}
