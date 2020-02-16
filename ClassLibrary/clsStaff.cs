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
        private string mFirstName;
        private string mLastName;
        private string mAddressLine;
        private string mPostCode;
        private Int32 mCountyNo;
        private string mPhoneNo;
        private Boolean mActive;

        public int StaffNo
        {
            get
            {
                return mStaffNo;
            }
            set
            {
                mStaffNo = value;
            }
        }

        public string StaffFirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        public string StaffLastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }
        public string AddressLine
        {
            get
            {
                return mAddressLine;
            }
            set
            {
                mAddressLine = value;
            }
        }
        public int CountyNo
        {
            get
            {
                return mCountyNo;
            }
            set
            {
                mCountyNo = value;
            }
        }
        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }

       public string PhoneNo
        {
            get
            {
                return mPhoneNo;
            }
            set
            {
                mPhoneNo = value;
            }
        }

        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

 

        public bool Find(int StaffNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffNo", StaffNo);
            DB.Execute("sproc_tblStaff_FilterByStaffNo");
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
            else
            {
                return false;
            }

           
        }

        public string Valid(string firstName, string lastName, string addressLine, string postCode, int countyNo, string phoneNo)
        {
            String Error = "";

            if (firstName.Length < 1)
            {
                Error = Error + "The first name may not be blank : ";
            }

            if (firstName.Length > 20)
            {
                Error = Error + "The first name may not be blank : ";
            }

            if (lastName.Length < 1)
            {
                Error = Error + "The last name may not be blank : ";
            }

            if (lastName.Length > 20)
            {
                Error = Error + "The last name may not be blank : ";
            }

            if (addressLine.Length < 10)
            {
                Error = Error + "The address line cannot be more than 40 characters : ";
            }

            if (addressLine.Length > 40)
            {
                Error = Error + "The address line cannot be more than 40 characters : ";
            }

            if (postCode.Length < 6)
            {
                Error = Error + "The postcode cannot be less than 5 characters : ";
            }

            if (postCode.Length > 10)
            {
                Error = Error + "The postcode cannot be less than 5 characters : ";
            }

            if (phoneNo.Length < 11)
            {
                Error = Error + "The postcode cannot be less than 5 characters : ";
            }

            if (phoneNo.Length > 15)
            {
                Error = Error + "The postcode cannot be less than 5 characters : ";
            }

            // return any error messages
            return Error;
        }
    }
}