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
        public void AddressLine1PropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            string StaffAddressLine1 = "29b";
            AStaff.AddressLine1 = StaffAddressLine1;
            Assert.AreEqual(AStaff.AddressLine1, StaffAddressLine1);
        }

        [TestMethod]
        public void AddressLine2PropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            string AddressLine2 = "Brick Road LE3 H6G";
            AStaff.AddressLine2 = AddressLine2;
            Assert.AreEqual(AStaff.AddressLine2, AddressLine2);
        }

        
    }
}
