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

        //public constructor for the class
        public clsStaffCollection()
        {
            //create an instance of the dataconnection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to get the list of data
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        // public list for staff
        public List<clsStaff> StaffList
        {
            get
            {
                // return the private data
                return mStaffList;
            }
            set
            {
                // set the private data
                mStaffList = value;
            }

        }

        // public method for count
        public int Count
        {
            get
            {
                // return the count of the list
                return mStaffList.Count;
            }
            set
            {
                // worry about later
            }

        }

        // public property for this staff
        public clsStaff ThisStaff
        {
            get
            {
                // return the private data 
                return mThisStaff;
            }
            set
            {
                // set the private data
                mThisStaff = value;
            }
        }

        // public method for add
        public int Add()
        {
            //adds a new record to the database based on the values of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
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

        // public method for delete
        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        // public method for update
        public void Update()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
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

        // public method for report last name
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

        // populate the array
        void PopulateArray (clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
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