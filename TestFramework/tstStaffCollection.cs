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
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
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
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }



        [TestMethod]
        public void ThisStaffPropertyOK()
        {
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

    }
}
