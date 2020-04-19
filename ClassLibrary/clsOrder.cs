using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderNo;
        private Int32 mFirstChoice;
        private Int32 mSecondChoice;
        private Int32 mThirdChoice;
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


        public int FirstChoice
        {
            get
            {
                return mFirstChoice;
            }
            set
            {
                mFirstChoice = value;
            }
        }
        public int SecondChoice
        {
            get
            {
                return mSecondChoice;
            }
            set
            {
                mSecondChoice = value;
            }
        }
        public int ThirdChoice
        {
            get
            {
                return mThirdChoice;
            }
            set
            {
                mThirdChoice = value;
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
                mFirstChoice = Convert.ToInt32(DB.DataTable.Rows[0]["FirstChoice"]);
                mSecondChoice = Convert.ToInt32(DB.DataTable.Rows[0]["SecondChoice"]);
                mThirdChoice = Convert.ToInt32(DB.DataTable.Rows[0]["ThirdChoice"]);
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

        public string Valid(string firstPrice, string secondPrice, string thirdPrice, string orderTotal)
        {
            // create a string variable to store the error
            String Error = "";
            // create a temporary variable to store the FirstPrice
            Int32 FirstPriceTemp;
            Int32 SecondPriceTemp;
            Int32 ThirdPriceTemp;
            Int32 OrderTotalTemp;

            // if the FirstPrice is blank
            try
            {
                FirstPriceTemp = Convert.ToInt32(firstPrice);
                if (FirstPriceTemp < 1)
                {
                    Error = Error + "The price cannot be in the past £1 : ";
                }

                if (FirstPriceTemp > 10)
                {
                    Error = Error + "The price cannot be more than £10 : ";
                }

                SecondPriceTemp = Convert.ToInt32(secondPrice);
                if (SecondPriceTemp < 1)
                {
                    Error = Error + "The price cannot be less than £1 : ";
                }

                if (SecondPriceTemp > 10)
                {
                    Error = Error + "The price cannot be more than £10 : ";
                }


                ThirdPriceTemp = Convert.ToInt32(thirdPrice);
                if (ThirdPriceTemp < 1)
                {
                    Error = Error + "The price cannot be less than £1 : ";
                }

                if (ThirdPriceTemp > 10)
                {
                    Error = Error + "The price cannot be more than £10 : ";
                }


                OrderTotalTemp = Convert.ToInt32(orderTotal);
                if (OrderTotalTemp < 1)
                {
                    Error = Error + "The total cannot be less than £1 : ";
                }

                if (OrderTotalTemp > 30)
                {
                    Error = Error + "The total cannot be more than £30 : ";
                }
            }
            catch
            {
                // record the error
                Error = Error + "The price was not a valid price : ";
            }
            return Error;
        }
    }
}