using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFramework
{
    [TestClass]
    public class tstStaff
    {
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
        public void PostCode()
        {
            clsStaff AStaff = new clsStaff();
            string PostCode = "LE3 4T6";
            AStaff.PostCode = PostCode;
            Assert.AreEqual(AStaff.PostCode, PostCode);
        }

        [TestMethod]
        public void PhoneNo()
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
            Int32 StaffNo = 34;
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
    }
}
