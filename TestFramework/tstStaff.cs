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
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffNoPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Int32 StaffNo = 2;
            AStaff.StaffNo = StaffNo;
            Assert.AreEqual(AStaff.StaffNo, StaffNo);
        }

        [TestMethod]
        public void StaffFirstNamePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            string StaffFirstName = "Mandy";
            AStaff.StaffFirstName = StaffFirstName;
            Assert.AreEqual(AStaff.StaffFirstName, StaffFirstName);
        }

        [TestMethod]
        public void StaffLastNamePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            string StaffLastName = "Braxton";
            AStaff.StaffLastName = StaffLastName;
            Assert.AreEqual(AStaff.StaffLastName, StaffLastName);
        }

        [TestMethod]
        public void AddressLinePropertyOK()
        {
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
            clsStaff AStaff = new clsStaff();
            string PostCode = "LE3 4T6";
            AStaff.PostCode = PostCode;
            Assert.AreEqual(AStaff.PostCode, PostCode);
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
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
            Int32 StaffNo = 1;
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
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the address no
            if (AStaff.StaffNo != 1)
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
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the address no
            if (AStaff.StaffFirstName != "Brad")
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
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the address no
            if (AStaff.StaffLastName != "Pitt")
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
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the address no
            if (AStaff.AddressLine != "6 Grange Lane")
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
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the address no
            if (AStaff.PostCode != "4HG 57G")
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
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the address no
            if (AStaff.PhoneNo != "0745375957")
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
            Int32 StaffNo = 1;
            //invoke the method
            Found = AStaff.Find(StaffNo);
            //check the address no
            if (AStaff.CountyNo != 1)
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
            Int32 StaffNo = 1;
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
            clsStaff AStaff = new clsStaff();
            String Error = "";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()  // 0 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string FirstName = "";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinBoundary()  // 1 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string FirstName = "a";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()  // 2 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string FirstName = "aa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()  // 19 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string FirstName = "aaaaaaaaaaaaaaaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxBoundary()  // 20 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string FirstName = "aaaaaaaaaaaaaaaaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()  // 21 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string FirstName = "aaaaaaaaaaaaaaaaaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()  // 10 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string FirstName = "aaaaaaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()  // 100 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(100, 'a');
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreNotEqual(Error, "");
        }


        // last name tests

        [TestMethod]
        public void LastNameMinLessOne()  // 0 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string LastName = "";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinBoundary()  // 1 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string LastName = "a";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()  // 2 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string LastName = "aa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()  // 19 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string LastName = "aaaaaaaaaaaaaaaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxBoundary()  // 20 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string LastName = "aaaaaaaaaaaaaaaaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()  // 21 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string FirstName = "aaaaaaaaaaaaaaaaaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()  // 10 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string FirstName = "aaaaaaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()  // 100 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string LastName = "";
            LastName = LastName.PadRight(100, 'a');
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreNotEqual(Error, "");
        }


        // address line tests


        [TestMethod]
        public void AddressLineMinLessOne()  // 9 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string AddressLine = "aaaaaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineMinBoundary()  // 10 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string AddressLine = "aaaaaaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineMinPlusOne()  // 11 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string AddressLine = "aaaaaaaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineMaxLessOne()  // 39 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string AddressLine = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineMaxBoundary()  // 40 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string AddressLine = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineMaxPlusOne()  // 41 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string AddressLine = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineExtremeMin()  // -300 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string AddressLine = "";
            AddressLine = AddressLine.PadRight(6, 'a');
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineExtremeMax()  // 300 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string AddressLine = "";
            AddressLine = AddressLine.PadRight(300, 'a');
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinLessOne()  // 5 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PostCode = "aaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinBoundary()  // 6 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PostCode = "aaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()  // 7 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PostCode = "aaaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxMinusOne()  // 9 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PostCode = "aaaaaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxBoundary()  // 10 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PostCode = "aaaaaaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()  // 11 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PostCode = "aaaaaaaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()  // 8 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PostCode = "aaaaaaaa";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeExtremeMax()  // 100 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PostCode = "";
            PostCode = PostCode.PadRight(100, 'a');
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinsLessOne()  // 10 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PhoneNo = "0765847392";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinBoundary()  // 11 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PhoneNo = "07658473926";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinPlusOne()  // 12 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PhoneNo = "076584739265";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxLessOne()  // 14 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PhoneNo = "07658473926222";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxBoundary()  // 15 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PhoneNo = "076584739266666";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxPlusOne()  // 16 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PhoneNo = "0765847392655555";
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoExtremeMax()  // 500 char
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PhoneNo = "";
            PhoneNo = PhoneNo.PadRight(500, 'a');
            Error = AStaff.Valid(FirstName, LastName, AddressLine, PostCode,  PhoneNo);
            Assert.AreNotEqual(Error, "");
        }
    }
}
