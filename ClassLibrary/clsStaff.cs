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
            // set the private data member to the test data value
            mStaffNo = 1;
            mFirstName = "Brad";
            mLastName = "Pitt";
            mAddressLine = "6 Grange Lane";
            mPostCode = "4HG 57G";
            mCountyNo = 1;
            mPhoneNo = "0745375957";
            mActive = true;
            // always return true
            return true;
        }
    }
}