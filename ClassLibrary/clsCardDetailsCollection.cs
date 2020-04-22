using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsCardDetailsCollection
    {
        // private data member for the list
        List<clsCardDetails> mCardDetailsList = new List<clsCardDetails>();

        clsCardDetails mThisCardDetails = new clsCardDetails();


        // constructor for the class
        public clsCardDetailsCollection()
        {
            // var to store the index
            Int32 Index = 0;
            // var to store the record count
            Int32 RecordCount = 0;
            // object for the data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblCardDetails_SelectAll");
            // get the count of records
            while (Index < RecordCount)
            {
                clsCardDetails ACardDetails = new clsCardDetails();
                // read in the fields from the current record
                ACardDetails.CardNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CardNo"]);
                ACardDetails.CardNo1 = Convert.ToString(DB.DataTable.Rows[Index]["Card1No"]);
                // add the record to the private data member
                mCardDetailsList.Add(ACardDetails);
                // point at the next record
                Index++;
            }



            //clsCardDetails TestItem = new clsCardDetails();
            //// set its properties
            //TestItem.CardNo = 1;
            //TestItem.CardNo1 = "123456";
            //TestItem.OrderNo = 1;
            //// add the item to the list
            //mCardDetailsList.Add(TestItem);
            //// re initialise the object for some new data
            //TestItem = new clsCardDetails();
            //// set its properties
            //TestItem.CardNo = 2;
            //TestItem.CardNo1 = "654321";
            //TestItem.OrderNo = 2;
            //// add the item to the list
            //mCardDetailsList.Add(TestItem);

            //clsDataConnection DB = new clsDataConnection();
            //// execute the stored procedure
            //DB.Execute("sproc_tblCardDetails_SelectAll");
            //// poplate the array list with the data
            //PopulateArray(DB);
        }



        public List<clsCardDetails> CardDetailsList
        {
            get
            {
                return mCardDetailsList;
            }
            set
            {
                mCardDetailsList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCardDetailsList.Count;
            }
            set
            {
                // worry bout later
            }

        }
        public clsCardDetails ThisCardDetails
        {
            get
            {
                return mThisCardDetails;
            }
            set
            {
                mThisCardDetails = value;
            }
        }


        // public method for Add
        public int Add()
        {
            // adds a new record to the database based on the values of the this order
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@CardNo1", mThisCardDetails.CardNo1);
            // execute the query returning the primary key value
            return DB.Execute("sproc_tblCardDetails_Insert");
        }
    }
}