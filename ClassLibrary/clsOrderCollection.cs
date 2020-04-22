using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        // private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        // priavte data member ThisOrder
        clsOrder mThisOrder = new clsOrder();

        //public constructor for the class
        public clsOrderCollection()
        {
            // set up the index for the loop
            Int32 Index = 0;
            // get the count of records
            Int32 RecordCount = 0;
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure to get the list of data
            DB.Execute("sproc_tblOrder_SelectAll");
            // get the count of records
            RecordCount = DB.Count;
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a new instace of the order class
                clsOrder AnOrder = new clsOrder();
                // read in the fields from the current record
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.FirstChoice = Convert.ToInt32(DB.DataTable.Rows[Index]["FirstChoice"]);
                AnOrder.SecondChoice = Convert.ToInt32(DB.DataTable.Rows[Index]["SecondChoice"]);
                AnOrder.ThirdChoice = Convert.ToInt32(DB.DataTable.Rows[Index]["ThirdChoice"]);
                AnOrder.FirstPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["FirstPrice"]);
                AnOrder.SecondPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["SecondPrice"]);
                AnOrder.ThirdPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["ThirdPrice"]);
                AnOrder.OrderTotal = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderTotal"]);
                // add the record to the private data member
                mOrderList.Add(AnOrder);
                // point at the next record
                Index++;

            }

        }

        //public list for orderlist
        public List<clsOrder> OrderList
        {
            get
            {
                // return private data member
                return mOrderList;
            }
            set
            {
                // set the private data member
                mOrderList = value;
            }
        }

        // public property for count
        public int Count
        {
            get
            {
                // return the private data member
                return mOrderList.Count;
            }
            set
            {
                //we will look at this in a moment!
            }
        }

        // public property for this order
        public clsOrder ThisOrder
        {
            get
            {
                // return the private data member
                return mThisOrder;
            }
            set
            {
                // set the private data member
                mThisOrder = value;
            }
        }

        // public method for Add
        public int Add()
        {
            // adds a new record to the database based on the values of the this order
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@FirstChoice", mThisOrder.FirstChoice);
            DB.AddParameter("@SecondChoice", mThisOrder.SecondChoice);
            DB.AddParameter("@ThirdChoice", ThisOrder.ThirdChoice);
            DB.AddParameter("@FirstPrice", ThisOrder.FirstPrice);
            DB.AddParameter("@SecondPrice", ThisOrder.SecondPrice);
            DB.AddParameter("@ThirdPrice", ThisOrder.ThirdPrice);
            DB.AddParameter("@OrderTotal", ThisOrder.OrderTotal);
            // execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        // public method for delete
        public void Delete()
        {
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        // public method for update
        public void Update()
        {
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@FirstChoice", mThisOrder.FirstChoice);
            DB.AddParameter("@SecondChoice", mThisOrder.SecondChoice);
            DB.AddParameter("@ThirdChoice", ThisOrder.ThirdChoice);
            DB.AddParameter("@FirstPrice", ThisOrder.FirstPrice);
            DB.AddParameter("@SecondPrice", ThisOrder.SecondPrice);
            DB.AddParameter("@ThirdPrice", ThisOrder.ThirdPrice);
            DB.AddParameter("@OrderTotal", ThisOrder.OrderTotal);
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }
    }
}