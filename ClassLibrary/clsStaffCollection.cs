using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        // private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        // private data member thisStaff
        clsStaff mThisStaff = new clsStaff();

        //public clsStaffCollection()
        //{
        //    clsStaff TestItem = new clsStaff();
        //    // set its properties
        //    TestItem.Active = true;
        //    TestItem.StaffNo = 1;
        //    TestItem.CountyNo = 1;
        //    TestItem.StaffFirstName = "Sally";
        //    TestItem.StaffLastName = "Gomery";
        //    TestItem.AddressLine = "8 Hillbilly State";
        //    TestItem.PostCode = "HG6 8SH";
        //    TestItem.PhoneNo = "07563856402";
        //    // add the item to the test list
        //    mStaffList.Add(TestItem);
        //    // reinitialise the object for some new data
        //    TestItem = new clsStaff();
        //    // set its properties
        //    TestItem.Active = true;
        //    TestItem.StaffNo = 2;
        //    TestItem.CountyNo = 2;
        //    TestItem.StaffFirstName = "Sam";
        //    TestItem.StaffLastName = "Grover";
        //    TestItem.AddressLine = "9 MushyLand Lane";
        //    TestItem.PostCode = "846 GH5";
        //    TestItem.PhoneNo = "07576490406";
        //    // assign the data to the property
        //    mStaffList.Add(TestItem);
        //}

        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
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
        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@LastName", mThisStaff.StaffLastName);
            DB.AddParameter("@AddressLine", mThisStaff.AddressLine);
            DB.AddParameter("@PostCode", mThisStaff.PostCode);
            DB.AddParameter("@CountyNo", mThisStaff.CountyNo);
            DB.AddParameter("@PhoneNo", mThisStaff.PhoneNo);
            DB.AddParameter("@Active", mThisStaff.Active);
            // execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            DB.AddParameter("@FirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@LastName", mThisStaff.StaffLastName);
            DB.AddParameter("@AddressLine", mThisStaff.AddressLine);
            DB.AddParameter("@PostCode", mThisStaff.PostCode);
            DB.AddParameter("@CountyNo", mThisStaff.CountyNo);
            DB.AddParameter("@PhoneNo", mThisStaff.PhoneNo);
            DB.AddParameter("@Active", mThisStaff.Active);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void ReportByLastName(string LastName)
        {
            // filters the records based on a full or partial surname
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // send the last name parameter to the database
            DB.AddParameter("@LastName", LastName);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByLastName");
            // populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray (clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff AStaff = new clsStaff();
                // read in the fields from the current records
                AStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AStaff.CountyNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CountyNo"]);
                AStaff.StaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AStaff.StaffLastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AStaff.AddressLine = Convert.ToString(DB.DataTable.Rows[Index]["AddressLine"]);
                AStaff.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AStaff.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                // add the record to the private data member
                mStaffList.Add(AStaff);
                // point at the next record
                Index++;
            }
        }
    }
}