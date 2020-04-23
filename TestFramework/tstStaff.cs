using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFramework
{
    [TestClass]
    public class tstStaff
    {
        // good test data
        // create some test data to pass to the method
        string FirstName = "Mandy";
        string LastName = "Francis";
        string AddressLine = "3 Diamond Road";
        string PostCode = "4HT 6UG";
        string PhoneNo = "07586937485";



        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffNoPropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            Int32 StaffNo = 2;
            AStaff.StaffNo = StaffNo;
            Assert.AreEqual(AStaff.StaffNo, StaffNo);
        }

        [TestMethod]
        public void StaffFirstNamePropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            string StaffFirstName = "Mandy";
            AStaff.StaffFirstName = StaffFirstName;
            Assert.AreEqual(AStaff.StaffFirstName, StaffFirstName);
        }

        [TestMethod]
        public void StaffLastNamePropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            string StaffLastName = "Braxton";
            AStaff.StaffLastName = StaffLastName;
            Assert.AreEqual(AStaff.StaffLastName, StaffLastName);
        }

        [TestMethod]
        public void AddressLinePropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            string AddressLine = "29b";
            AStaff.AddressLine = AddressLine;
            Assert.AreEqual(AStaff.AddressLine, AddressLine);
        }

        [TestMethod]
        public void CountyNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.CountyNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.CountyNo, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            string PostCode = "LE3 4T6";
            AStaff.PostCode = PostCode;
            Assert.AreEqual(AStaff.PostCode, PostCode);
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            string PhoneNo = "07463837463";
            AStaff.PhoneNo = PhoneNo;
            Assert.AreEqual(AStaff.PhoneNo, PhoneNo);
        }


        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Active, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffNo = 3;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 3;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the address no
            if (AStaff.StaffNo != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 3;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the address no
            if (AStaff.StaffFirstName != "Sally")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 3;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the address no
            if (AStaff.StaffLastName != "Phoebe")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 3;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the address no
            if (AStaff.AddressLine != "8 Hillbilly State")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 3;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the address no
            if (AStaff.PostCode != "HG6 8SH")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 3;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the address no
            if (AStaff.PhoneNo != "07563856402")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCountyNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 3;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the address no
            if (AStaff.CountyNo != 13)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 3;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the address no
            if (AStaff.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()  // 0 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinBoundary()  // 1 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "a";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()  // 2 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()  // 19 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxBoundary()  // 20 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()  // 21 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()  // 10 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()  // 100 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(100, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        // last name tests

        [TestMethod]
        public void LastNameMinLessOne()  // 0 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinBoundary()  // 1 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "a";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()  // 2 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()  // 19 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the 
            string LastName = "aaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxBoundary()  // 20 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()  // 21 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()  // 10 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()  // 100 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(100, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        // address line tests


        [TestMethod]
        public void AddressLineMinLessOne()  // 9 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AddressLine = "aaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineMinBoundary()  // 10 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AddressLine = "aaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineMinPlusOne()  // 11 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AddressLine = "aaaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineMaxLessOne()  // 39 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AddressLine = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineMaxBoundary()  // 40 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error 
            String Error = "";
            //create some test data to pass to the method
            string AddressLine = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineMaxPlusOne()  // 41 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AddressLine = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AddressLineExtremeMax()  // 300 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error 
            String Error = "";
            //create some test data to pass to the method
            string AddressLine = "";
            AddressLine = AddressLine.PadRight(300, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinLessOne()  // 5 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "aaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinBoundary()  // 6 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "aaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()  // 7 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "aaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxMinusOne()  // 9 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "aaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxBoundary()  // 10 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "aaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()  // 11 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "aaaaaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()  // 8 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the 
            string PostCode = "aaaaaaaa";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeExtremeMax()  // 100 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(100, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinsLessOne()  // 10 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = "0765847392";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinBoundary()  // 11 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = "07658473926";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinPlusOne()  // 12 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = "076584739265";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxLessOne()  // 14 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error 
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = "07658473926222";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxBoundary()  // 15 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = "076584739266666";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxPlusOne()  // 16 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = "0765847392655555";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoExtremeMax()  // 500 char
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNo = "";
            PhoneNo = PhoneNo.PadRight(500, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreNotEqual(Error, "");
        }
    }
}
