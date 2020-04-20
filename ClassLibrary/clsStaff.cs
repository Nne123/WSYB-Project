using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsStaff
    {
        // private data member for the StaffNo
        private Int32 mStaffNo;
        // private data member for the first name
        private string mFirstName;
        // private data member for the last name
        private string mLastName;
        // private data member for the address line
        private string mAddressLine;
        // private data member for the post code
        private string mPostCode;
        // private data member for the county no
        private Int32 mCountyNo;
        // private data member for the phone no
        private string mPhoneNo;
        // private data member for the active
        private Boolean mActive;

        // public property for staff no
        public int StaffNo
        {
            get
            {
                // return the private data
                return mStaffNo;
            }
            set
            {
                // set the private data
                mStaffNo = value;
            }
        }

        // public property for staff name
        public string StaffFirstName
        {
            get
            {
                // return the private data
                return mFirstName;
            }
            set
            {
                // set the private data
                mFirstName = value;
            }
        }

        // public property for staff last name
        public string StaffLastName
        {
            get
            {
                // return the private data 
                return mLastName;
            }
            set
            {
                // set the private data
                mLastName = value;
            }
        }

        // public property for address line
        public string AddressLine
        {
            get
            {
                // return the private data
                return mAddressLine;
            }
            set
            {
                // set the private data
                mAddressLine = value;
            }
        }

        // public property for countyno
        public int CountyNo
        {
            get
            {
                // return the private data 
                return mCountyNo;
            }
            set
            {
                // set the private data
                mCountyNo = value;
            }
        }

        // public property for post code
        public string PostCode
        {
            get
            {
                // return the private data
                return mPostCode;
            }
            set
            {
                // set the private data
                mPostCode = value;
            }
        }

        // public property for phone no
       public string PhoneNo
        {
            get
            {
                // return the private data
                return mPhoneNo;
            }
            set
            {
                // set the private data
                mPhoneNo = value;
            }
        }

        // public property for active
        public bool Active
        {
            get
            {
                // return the private data
                return mActive;
            }
            set
            {
                // set the private data
                mActive = value;
            }
        }

 
        // public method for find
        public bool Find(int StaffNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff no to search for
            DB.AddParameter("@StaffNo", StaffNo);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                // set the private data member to the test data value
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mAddressLine = Convert.ToString(DB.DataTable.Rows[0]["AddressLine"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mCountyNo = Convert.ToInt32(DB.DataTable.Rows[0]["CountyNo"]);
                mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                // always return true
                return true;
            }
            // if no record is found
            else
            {
                // return false indicating a problem
                return false;
            }

           
        }

        // public method for valid
        public string Valid(string firstName, string lastName, string addressLine, string postCode, /*int countyNo,*/ string phoneNo)
        {
            //create a string variable to store the error
            String Error = "";

            // if the first name is blank
            if (firstName.Length < 1)
            {
                // record the error
                Error = Error + "The first name may not be blank : ";
            }

            // if the first name is more than 20 characters
            if (firstName.Length > 20)
            {
                // record the error
                Error = Error + "The first name cannot be more than 20 characters : ";
            }

            // if the last name is blank
            if (lastName.Length < 1)
            {
                // record the error
                Error = Error + "The last name may not be blank : ";
            }

            // if the last name is more than 20 characters
            if (lastName.Length > 20)
            {
                // record the error
                Error = Error + "The last name cannot be more than 20 characters long : ";
            }

            // if the address line is less than 10 characters
            if (addressLine.Length < 10)
            {
                // record the error
                Error = Error + "The address line cannot be less than 10 characters : ";
            }

            // if the address line is more than 40 characters
            if (addressLine.Length > 40)
            {
                // record the error
                Error = Error + "The address line cannot be more than 40 characters : ";
            }

            // if the post code length is less than 6 characters
            if (postCode.Length < 6)
            {
                // record the error
                Error = Error + "The postcode cannot be less than 6 characters : ";
            }

            // if the psot code is more than 10 characters
            if (postCode.Length > 10)
            {
                // record the error
                Error = Error + "The postcode cannot be less than 10 characters : ";
            }

            // if the phone no is less than 11 characters
            if (phoneNo.Length < 11)
            {
                // record the error
                Error = Error + "The phone number cannot be less than 11 characters : ";
            }

            // if the phone no is more than 15 characters
            if (phoneNo.Length > 15)
            {
                // record the error
                Error = Error + "The phone number cannot be less than 15 characters : ";
            }

            // return any error messages
            return Error;
        }
    }
}