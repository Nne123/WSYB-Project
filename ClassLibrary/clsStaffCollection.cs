using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        // private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();


        public clsStaffCollection()
        {
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
            // add the item to the test list
            mStaffList.Add(TestItem);
            // reinitialise the object for some new data
            TestItem = new clsStaff();
            // set its properties
            TestItem.Active = true;
            TestItem.StaffNo = 2;
            TestItem.CountyNo = 2;
            TestItem.StaffFirstName = "Sam";
            TestItem.StaffLastName = "Grover";
            TestItem.AddressLine = "9 MushyLand Lane";
            TestItem.PostCode = "846 GH5";
            TestItem.PhoneNo = "07576490406";
            // assign the data to the property
            mStaffList.Add(TestItem);
        }

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }

        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                // worry about later
            }

        }
        public clsStaff ThisStaff { get; set; }
    }
}