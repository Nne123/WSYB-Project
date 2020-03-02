using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderNo;
        private Int32 mFirstMenuItem;
        private Int32 mSecondMenuItem;
        private Int32 mThirdMenuItem;
        private Int32 mFirstPrice;
        private Int32 mSecondPrice;
        private Int32 mThirdPrice;
        private Int32 mOrderTotal;


        public int OrderNo
        {
            get
            {
                return mOrderNo;
            }
            set
            {
                mOrderNo = value;
            }
        }
        public int FirstMenuItem
        {
            get
            {
                return mFirstMenuItem;
            }
            set
            {
                mFirstMenuItem = value;
            }
        }
        public int SecondMenuItem
        {
            get
            {
                return mSecondMenuItem;
            }
            set
            {
                mSecondMenuItem = value;
            }
        }
        public int ThirdMenuItem
        {
            get
            {
                return mThirdMenuItem;
            }
            set
            {
                mThirdMenuItem = value;
            }
        }
        public int FirstPrice
        {
            get
            {
                return mFirstPrice;
            }
            set
            {
                mFirstPrice = value;
            }
        }
        public int SecondPrice
        {
            get
            {
                return mSecondPrice;
            }
            set
            {
                mSecondPrice = value;
            }
        }
        public int ThirdPrice
        {
            get
            {
                return mThirdPrice;
            }
            set
            {
                mThirdPrice = value;
            }
        }
        public int OrderTotal
        {
            get
            {
                return mOrderTotal;
            }
            set
            {
                mOrderTotal = value;
            }
        }
        public bool Find(int OrderNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", OrderNo);
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            if (DB.Count == 1)
            {
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mFirstMenuItem = Convert.ToInt32(DB.DataTable.Rows[0]["FirstMenuItem"]);
                mSecondMenuItem = Convert.ToInt32(DB.DataTable.Rows[0]["SecondMenuItem"]);
                mThirdMenuItem = Convert.ToInt32(DB.DataTable.Rows[0]["ThirdMenuItem"]);
                mFirstPrice = Convert.ToInt32(DB.DataTable.Rows[0]["FirstPrice"]);
                mSecondPrice = Convert.ToInt32(DB.DataTable.Rows[0]["SecondPrice"]);
                mThirdPrice = Convert.ToInt32(DB.DataTable.Rows[0]["ThirdPrice"]);
                mOrderTotal = Convert.ToInt32(DB.DataTable.Rows[0]["OrderTotal"]);
                // always true
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public string Valid()
        {
            return "";
        }
    }
}