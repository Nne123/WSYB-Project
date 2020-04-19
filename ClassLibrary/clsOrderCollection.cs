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

        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
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

            //clsOrder TestItem = new clsOrder();
            //// set its properties
            //TestItem.OrderNo = 2;
            //TestItem.FirstMenuItem = 3;
            //TestItem.SecondMenuItem = 2;
            //TestItem.ThirdtMenuItem = 1;
            //TestItem.FirstPrice = 3;
            //TestItem.SecondPrice = 2;
            //TestItem.ThirdPrice = 1;
            //TestItem.OrderTotal = 6;
            //// add the item to the list
            //mOrderList.Add(TestItem);
            //// re initialise the object for some new data
            //TestItem = new clsOrder();
            //// set its properties
            //TestItem.OrderNo = 1;
            //TestItem.FirstMenuItem = 2;
            //TestItem.SecondMenuItem = 3;
            //TestItem.ThirdtMenuItem = 3;
            //TestItem.FirstPrice = 4;
            //TestItem.SecondPrice = 4;
            //TestItem.ThirdPrice = 3;
            //TestItem.OrderTotal = 11;
            //// add the item to the list
            //mOrderList.Add(TestItem);
        }

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                // later
            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstChoice", mThisOrder.FirstChoice);
            DB.AddParameter("@SecondChoice", mThisOrder.SecondChoice);
            DB.AddParameter("@ThirdChoice", ThisOrder.ThirdChoice);
            DB.AddParameter("@FirstPrice", ThisOrder.FirstPrice);
            DB.AddParameter("@SecondPrice", ThisOrder.SecondPrice);
            DB.AddParameter("@ThirdPrice", ThisOrder.ThirdPrice);
            DB.AddParameter("@OrderTotal", ThisOrder.OrderTotal);
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
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