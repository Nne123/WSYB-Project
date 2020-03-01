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

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    clsMenuItemCollection AllMenuItems = new clsMenuItemCollection();
        //    Int32 SomeCount = 3;
        //    AllMenuItems.Count = SomeCount;
        //    Assert.AreEqual(AllMenuItems.Count, SomeCount);
        //}

        [TestMethod]
        public void MenuItemListOK()  // MenuItemListOK
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
            MenuItems.MenuItemList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(MenuItems.MenuItemList, TestList);
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
            MenuItems.MenuItemList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(MenuItems.Count, TestList.Count);
        }


        //[TestMethod]
        //public void TwoMenuItemsPresent()
        //{
        //    clsMenuItemCollection MenuItems = new clsMenuItemCollection();
        //    Assert.AreEqual(MenuItems.Count, 2);
        //}



        [TestMethod]
        public void ThisMenuItemPropertyOK()
        {
            clsMenuItemCollection AllMenuItems = new clsMenuItemCollection();
            // create some test data to assign to the property
            clsMenuItem TestMenuItem = new clsMenuItem();
            // set the properties of the test object
            TestMenuItem.MenuItemNo = 1;
            TestMenuItem.MenuItem = "Grapes";
            TestMenuItem.MenuItemPrice = 4;
            // add the item to the test list
            AllMenuItems.ThisMenuItem = TestMenuItem;
            // test to see that the two values are the same
            Assert.AreEqual(AllMenuItems.ThisMenuItem, TestMenuItem);
        }

        //[TestMethod]
        //public void ListAndCountOK()
        //{
        //    clsMenuItemCollection AllMenuItems = new clsMenuItemCollection();
        //    // create some test data to assign to the property
        //    List<clsMenuItem> TestList = new List<clsMenuItem>();
        //    clsMenuItem TestItem = new clsMenuItem();
        //    // set the properties of the test object
        //    TestItem.MenuItemNo = 1;
        //    TestItem.MenuItem = "Grapes";
        //    TestItem.MenuItemPrice = 4;
        //    // add the item to the test list
        //    TestList.Add(TestItem);
        //    AllMenuItems.MenuItemList = TestList;
        //    // test to see that the two values are the same
        //    Assert.AreEqual(AllMenuItems.Count, TestList.Count);
        //}

        [TestMethod]
        public void AddMethodOK()
        {
            clsMenuItemCollection AllMenuItems = new clsMenuItemCollection();
            // create some test data to assign to the property
            clsMenuItem TestItem = new clsMenuItem();
            Int32 PrimaryKey = 0;
            // set the properties of the test object
            TestItem.MenuItemNo = 1;
            TestItem.MenuItem = "Grapes";
            TestItem.MenuItemPrice = 4;
            // set this menu item to the test data
            AllMenuItems.ThisMenuItem = TestItem;
            // add the record
            PrimaryKey = AllMenuItems.Add();
            // set the primary key of the test data
            TestItem.MenuItemNo = PrimaryKey;
            // find the record
            AllMenuItems.ThisMenuItem.Find(PrimaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(AllMenuItems.ThisMenuItem, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsMenuItemCollection AllMenuItems = new clsMenuItemCollection();
            // create some test data to assign to the property
            clsMenuItem TestItem = new clsMenuItem();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            // set the properties of the test object
            TestItem.MenuItemNo = 1;
            TestItem.MenuItem = "Grapes";
            TestItem.MenuItemPrice = 4;
            // set this menu item to the test data
            AllMenuItems.ThisMenuItem = TestItem;
            // add the record
            PrimaryKey = AllMenuItems.Add();
            // set the primary key of the test data
            TestItem.MenuItemNo = PrimaryKey;
            // find the record
            AllMenuItems.ThisMenuItem.Find(PrimaryKey);
            // delete the record
            AllMenuItems.Delete();
            // now find the record
            Boolean Found = AllMenuItems.ThisMenuItem.Find(PrimaryKey);
            // test to see that the two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsMenuItemCollection AllMenuItems = new clsMenuItemCollection();
            // create some test data to assign to the property
            clsMenuItem TestItem = new clsMenuItem();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            // set the properties of the test object
            TestItem.MenuItem = "Grapes";
            TestItem.MenuItemPrice = 4;
            // set this menu item to the test data
            AllMenuItems.ThisMenuItem = TestItem;
            // add the record
            PrimaryKey = AllMenuItems.Add();
            // set the primary key of the test data
            TestItem.MenuItemNo = PrimaryKey;
            // modify the test data
            TestItem.MenuItem = "Qiwi";
            TestItem.MenuItemPrice = 2;
            // set the record based on the new test data
            AllMenuItems.ThisMenuItem = TestItem;
            // update the record
            AllMenuItems.Update();
            // find the record
            AllMenuItems.ThisMenuItem.Find(PrimaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(AllMenuItems.ThisMenuItem, TestItem);
        }

    }
}
