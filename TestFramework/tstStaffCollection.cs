using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestFramework
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            // set its properties
            TestItem.Active = true;
            TestItem.StaffNo = 1;
            TestItem.CountyNo = 1;
            TestItem.StaffFirstName = "Sally";
            TestItem.StaffLastName = "Gomery";
            TestItem.AddressLine = "8 Hillbilly State";
            TestItem.PostCode = "HG6 8SH";
            TestItem.PhoneNo = "07563856402";
            // add the itme to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }



        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class 
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            // set its properties
            TestStaff.Active = true;
            TestStaff.StaffNo = 1;
            TestStaff.CountyNo = 1;
            TestStaff.StaffFirstName = "Sally";
            TestStaff.StaffLastName = "Gomery";
            TestStaff.AddressLine = "8 Hillbilly State";
            TestStaff.PostCode = "HG6 8SH";
            TestStaff.PhoneNo = "07563856402";
            // add the itme to the test list
            AllStaff.ThisStaff = TestStaff;
            // assign the data to the property
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class 
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            // set its properties
            TestItem.Active = true;
            TestItem.StaffNo = 1;
            TestItem.CountyNo = 1;
            TestItem.StaffFirstName = "Sally";
            TestItem.StaffLastName = "Gomery";
            TestItem.AddressLine = "8 Hillbilly State";
            TestItem.PostCode = "HG6 8SH";
            TestItem.PhoneNo = "07563856402";
            // add the itme to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.StaffNo = 1;
            TestItem.CountyNo = 1;
            TestItem.StaffFirstName = "Sally";
            TestItem.StaffLastName = "Gomery";
            TestItem.AddressLine = "8 Hillbilly State";
            TestItem.PostCode = "HG6 8SH";
            TestItem.PhoneNo = "07563856402";
            //set ThisAddress to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.StaffNo = 1;
            TestItem.CountyNo = 1;
            TestItem.StaffFirstName = "Sally";
            TestItem.StaffLastName = "Gomery";
            TestItem.AddressLine = "8 Hillbilly State";
            TestItem.PostCode = "HG6 8SH";
            TestItem.PhoneNo = "07563856402";
            //set ThisAddress to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            // delete the record
            AllStaff.Delete();
            // now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.StaffNo = 1;
            TestItem.CountyNo = 1;
            TestItem.StaffFirstName = "Sally";
            TestItem.StaffLastName = "Gomery";
            TestItem.AddressLine = "8 Hillbilly State";
            TestItem.PostCode = "HG6 8SH";
            TestItem.PhoneNo = "07563856402";
            //set ThisAddress to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            // modify the test data
            TestItem.Active = false;
            TestItem.StaffNo = 5;
            TestItem.CountyNo = 5;
            TestItem.StaffFirstName = "Shade";
            TestItem.StaffLastName = "Fishers";
            TestItem.AddressLine = "7 Luther Day ";
            TestItem.PostCode = "7G9 LEO";
            TestItem.PhoneNo = "07563856409";
            // set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            // update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void ReportByLastNameMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            // apply a blank string (should return all records)
            FilteredStaff.ReportByLastName("");
            // test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByLastNameNoneFound()
        {
            //create an instance of the class we want to create
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            // apply a blank string (should return all records)
            FilteredStaff.ReportByLastName("xxxxxxx");
            // test to see that the two values are the same
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        //[TestMethod]
        //public void ReportByLastNameTestDataFound()
        //{
        //    //create an instance of the class we want to create
        //    clsStaffCollection FilteredStaff = new clsStaffCollection();
        //    Boolean OK = true;
        //    FilteredStaff.ReportByLastName("Gomery");
        //    if (FilteredStaff.Count == 2)
        //    {
        //        //check that the first record is ID 3
        //        if (FilteredStaff.StaffList[0].StaffNo != 3)
        //        {
        //            OK = false;
        //        }
        //        //check that the first record is ID 7
        //        if (FilteredStaff.StaffList[0].StaffNo != 7)
        //        {
        //            OK = false;
        //        }
        //    }
        //    else
        //    {
        //        OK = false;
        //    }
        //    //test to see that there are no records
        //    Assert.IsTrue(OK);
        //}
    }
}
