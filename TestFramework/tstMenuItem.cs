using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFramework
{
    [TestClass]
    public class tstMenuItem
    {
        //good test data
        //create some test data to pass to the method
        string MenuItem = "Apple";
        string MenuItemPrice = Convert.ToString(3);
        

        // The class exists
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            // test to see that it exists
            Assert.IsNotNull(AMenuItem);
        }

        // the menu property 

        [TestMethod]
        public void MenuItemPropertyOK()
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //create some test data to assign to the property
            string SomeMenuItem = "Strawberry";
            //assign the data to the property
            AMenuItem.MenuItem = SomeMenuItem;
            // test to see that the two values are the same
            Assert.AreEqual(AMenuItem.MenuItem, SomeMenuItem);
        }

        [TestMethod]
        public void MenuItemNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //create some test data to assign to the property
            Int32 MenuItemNo = 1;
            //assign the data to the property
            AMenuItem.MenuItemNo = MenuItemNo;
            // test to see that the two values are the same
            Assert.AreEqual(AMenuItem.MenuItemNo, MenuItemNo);
        }

        // valid method ok

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //string variable to store any error message
            String Error = "";
            //string SomeMenuItem = "Strawberry";
            Error = AMenuItem.Valid(MenuItem, MenuItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MenuItemPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //create some test data to assign to the property
            Int32 someMenuItemPrice = 1;
            //assign the data to the property
            AMenuItem.MenuItemPrice = someMenuItemPrice;
            //test to see that the two values are the same
            Assert.AreEqual(AMenuItem.MenuItemPrice, someMenuItemPrice);
        }

        // menu item min less one

        [TestMethod]
        public void MenuItemMinLessOne()    // 0 char FAIL
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeMenuItem = "";
            //invoke the method
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        // menu item min boundary

        [TestMethod]
        public void MenuItemMinBoundary()  // 1 char PASS
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeMenuItem = "a";
            //invoke the method
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        // menu item min plus one

        [TestMethod]
        public void MenuItemMinPlusOne()   // 2 char  PASS
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeMenuItem = "aa";
            //invoke the method
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        // menu item max less one

        [TestMethod]
        public void MenuItemMaxLessOne()  // 19 char  PASS
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeMenuItem = "aaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        // menu item max boundary

        [TestMethod]
        public void MenuItemMaxBoundary()   // 20 char PASS
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeMenuItem = "aaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        // menu item max plus one

        [TestMethod]
        public void MenuItemMaxPlusOne()   // 21 char  FAIL
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeMenuItem = "aaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        // menu item mid

        [TestMethod]
        public void MenuItemMid()   // 10 char  PASS
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeMenuItem = "aaaaaaaaaa";
            //invoke the method
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MenuItemExtremeMax()   // 100 char  FAIL
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeMenuItem = "";
            SomeMenuItem = SomeMenuItem.PadRight(100, 'a');
            //invoke the method
            Error = AMenuItem.Valid(SomeMenuItem, MenuItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void MenuItemPriceMinLessOne()    // 0 int FAIL
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 0;
            string MenuItemPrice = TestPrice.ToString();
            //invoke the method
            Error = AMenuItem.Valid(MenuItem, MenuItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MenuItemPriceMinBoundary()    // 1 int PASS
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 1;
            string MenuItemPrice = TestPrice.ToString();
            //invoke the method
            Error = AMenuItem.Valid(MenuItem, MenuItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MenuItemPriceMinPlusOne()    // 2 int PASS
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 2;
            string MenuItemPrice = TestPrice.ToString();
            //invoke the method
            Error = AMenuItem.Valid(MenuItem, MenuItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MenuItemPriceMaxMinusOne()    // 9 int PASS
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 9;
            string MenuItemPrice = TestPrice.ToString();
            //invoke the method
            Error = AMenuItem.Valid(MenuItem, MenuItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void MenuItemPriceMaxBoundary()    // 10 int PASS
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 10;
            string MenuItemPrice = TestPrice.ToString();
            //invoke the method
            Error = AMenuItem.Valid(MenuItem, MenuItemPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void MenuItemPriceMaxPlusOne()    // 11 int FAIL
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 11;
            string MenuItemPrice = TestPrice.ToString();
            //invoke the method
            Error = AMenuItem.Valid(MenuItem, MenuItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void MenuItemPriceExtremeMax()    // 100 int FAIL
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestPrice;
            TestPrice = 100;
            string MenuItemPrice = TestPrice.ToString();
            //invoke the method
            Error = AMenuItem.Valid(MenuItem, MenuItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void MenuItemPriceInvalidData()    // invalid data FAIL
        {
            //create an instance of the class we want to 
            clsMenuItem AMenuItem = new clsMenuItem();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string MenuItem = "Kiwi";
            string MenuItemPrice = "This is not a price!";
            //invoke the method
            Error = AMenuItem.Valid(MenuItem, MenuItemPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 MenuItemNo = 1;
            //invoke the method
            Found = AMenuItem.Find(MenuItemNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }




        [TestMethod]
        public void TestMenuItemNoFound()
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 MenuItemNo = 1;
            //invoke the method
            Found = AMenuItem.Find(MenuItemNo);
            //check the menu item no
            if (AMenuItem.MenuItemNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestMenuItemFound()
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 MenuItemNo = 1;
            //invoke the method
            Found = AMenuItem.Find(MenuItemNo);
            //check the menu item no
            if (AMenuItem.MenuItem != "Mango")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestMenuItemPriceFound()
        {
            //create an instance of the class we want to create
            clsMenuItem AMenuItem = new clsMenuItem();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 MenuItemNo = 1;
            //invoke the method
            Found = AMenuItem.Find(MenuItemNo);
            //check the menu item no
            if (AMenuItem.MenuItemPrice != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
