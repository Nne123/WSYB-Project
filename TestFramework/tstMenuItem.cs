using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFramework
{
    [TestClass]
    public class tstMenuItem
    {
        string MenuItemPrice = Convert.ToString(3);
        string SomeMenuItem = "Apple";

        // The class exists

        [TestMethod]
        public void InstanceOK()
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            Assert.IsNotNull(AMenuItem);
        }

        // the menu property 

        [TestMethod]
        public void MenuItemPropertyOK()
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            string SomeMenuItem = "Strawberry";
            AMenuItem.MenuItem = SomeMenuItem;
            Assert.AreEqual(AMenuItem.MenuItem, SomeMenuItem);
        }

        // the menu no property 

        [TestMethod]
        public void MenuItemNoPropertyOK()
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            Int32 MenuItemNo = 1;
            AMenuItem.MenuItemNo = MenuItemNo;
            Assert.AreEqual(AMenuItem.MenuItemNo, MenuItemNo);
        }

        [TestMethod]
        public void MenuItemPricePropertyOK()
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            Int32 MenuItemPrice = 1;
            AMenuItem.MenuItemPrice = MenuItemPrice;
            Assert.AreEqual(AMenuItem.MenuItemPrice, MenuItemPrice);
        }

        // valid method ok

        [TestMethod]
        public void ValidMethodOK()
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            String Error = "";
            string SomeMenuItem = "Strawberry";
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            Assert.AreEqual(Error, "");
        }

        // menu item min less one

        [TestMethod]
        public void MenuItemMinLessOne()    // 4 char FAIL
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            String Error = "";
            string SomeMenuItem = "aaaa";
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        // menu item min boundary

        [TestMethod]
        public void MenuItemMinBoundary()  // 5 char PASS
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            String Error = "";
            string SomeMenuItem = "aaaaa";
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            Assert.AreEqual(Error, "");
        }

        // menu item min plus one

        [TestMethod]
        public void MenuItemMinPlusOne()   // 6 char  PASS
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            String Error = "";
            string SomeMenuItem = "aaaaaa";
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            Assert.AreEqual(Error, "");
        }

        // menu item max less one

        [TestMethod]
        public void MenuItemMaxLessOne()  // 19 char  PASS
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            String Error = "";
            string SomeMenuItem = "aaaaaaaaaaaaaaaaaaa";
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            Assert.AreEqual(Error, "");
        }

        // menu item max boundary

        [TestMethod]
        public void MenuItemMaxBoundary()   // 20 char PASS
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            String Error = "";
            string SomeMenuItem = "aaaaaaaaaaaaaaaaaaaa";
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            Assert.AreEqual(Error, "");
        }

        // menu item max plus one

        [TestMethod]
        public void MenuItemMaxPlusOne()   // 21 char  FAIL
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            String Error = "";
            string SomeMenuItem = "aaaaaaaaaaaaaaaaaaaaaa";
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        // menu item mid

        [TestMethod]
        public void MenuItemMid()   // 12 char  PASS
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            String Error = "";
            string SomeMenuItem = "aaaaaaaaaaaa";
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MenuItemExtremeMax()   // 100 char  FAIL
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            String Error = "";
            string SomeMenuItem = "";
            SomeMenuItem = SomeMenuItem.PadRight(100, 'a');
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void MenuItemPriceMinLessOne()    // 0 int FAIL
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            String Error = "";
            Int32 TestPrice;
            TestPrice = 0;
            string MenuItemPrice = TestPrice.ToString();
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MenuItemPriceMinBoundary()    // 1 int PASS
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            String Error = "";
            Int32 TestPrice;
            TestPrice = 1;
            string MenuItemPrice = TestPrice.ToString();
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MenuItemPriceMinPlusOne()    // 2 int PASS
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            String Error = "";
            Int32 TestPrice;
            TestPrice = 2;
            string MenuItemPrice = TestPrice.ToString();
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MenuItemPriceMaxMinusOne()    // 9 int PASS
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            String Error = "";
            Int32 TestPrice;
            TestPrice = 9;
            string MenuItemPrice = TestPrice.ToString();
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void MenuItemPriceMaxBoundary()    // 10 int PASS
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            String Error = "";
            Int32 TestPrice;
            TestPrice = 10;
            string MenuItemPrice = TestPrice.ToString();
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void MenuItemPriceMaxPlusOne()    // 11 int PASS
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            String Error = "";
            Int32 TestPrice;
            TestPrice = 11;
            string MenuItemPrice = TestPrice.ToString();
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void MenuItemPriceExtremeMax()    // 100 int PASS
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            String Error = "";
            Int32 TestPrice;
            TestPrice = 100;
            string MenuItemPrice = TestPrice.ToString();
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void MenuItemPriceInvalidData()    // invalid data FAIL
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            String Error = "";
            string MenuItemPrice = "this is not a price!";
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            Assert.AreNotEqual(Error, "");
        }
    }
}
