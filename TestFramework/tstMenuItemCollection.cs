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
        public void MenuItemListOK()
        {
            clsMenuItemCollection AllMenuItems = new clsMenuItemCollection();
            List<clsMenuItem> TestList = new List<clsMenuItem>();
            clsMenuItem TestItem = new clsMenuItem();
            TestItem.MenuItemNo = 1;
            TestItem.MenuItem = "Strawberry";
            TestItem.MenuItemPrice = 3;
            TestList.Add(TestItem);
            AllMenuItems.MenuItemList = TestList;
            Assert.AreEqual(AllMenuItems.MenuItemList, TestList); 
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
        public void ThisMenuItemPropertyOK()
        {
            clsMenuItemCollection AllMenuItems = new clsMenuItemCollection();
            clsMenuItem TestMenuItem = new clsMenuItem();
            TestMenuItem.MenuItemNo = 1;
            TestMenuItem.MenuItem = "Strawberry";
            TestMenuItem.MenuItemPrice = 3;
            AllMenuItems.ThisMenuItem = TestMenuItem;
            Assert.AreEqual(AllMenuItems.ThisMenuItem, TestMenuItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsMenuItemCollection AllMenuItems = new clsMenuItemCollection();
            List<clsMenuItem> TestList = new List<clsMenuItem>();
            clsMenuItem TestMenuItem = new clsMenuItem();
            TestMenuItem.MenuItemNo = 1;
            TestMenuItem.MenuItem = "Strawberry";
            TestMenuItem.MenuItemPrice = 3;
            TestList.Add(TestMenuItem);
            AllMenuItems.MenuItemList = TestList;
            Assert.AreEqual(AllMenuItems.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsMenuItemCollection AllMenuItems = new clsMenuItemCollection();
            Assert.AreEqual(AllMenuItems.Count, 2);
        }

    }
}
