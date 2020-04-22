using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsOrder
    {
        // var to store private data members
        private Int32 mOrderNo;
        private Int32 mFirstChoice;
        private Int32 mSecondChoice;
        private Int32 mThirdChoice;
        private Int32 mFirstPrice;
        private Int32 mSecondPrice;
        private Int32 mThirdPrice;
        private Int32 mOrderTotal;


        // public property for OrderNo
        public int OrderNo
        {
            get
            {
                // get the private data 
                return mOrderNo;
            }
            set
            {
                // set the private data
                mOrderNo = value;
            }
        }

        // public property for First Choice
        public int FirstChoice
        {
            get
            {
                // get the private data
                return mFirstChoice;
            }
            set
            {
                // set the private data
                mFirstChoice = value;
            }
        }

        // public property for Second Choice
        public int SecondChoice
        {
            get
            {
                // get the private data
                return mSecondChoice;
            }
            set
            {
                // set the private data
                mSecondChoice = value;
            }
        }

        // public property for Third Choice
        public int ThirdChoice
        {
            get
            {
                // get the private data
                return mThirdChoice;
            }
            set
            {
                // set the private data
                mThirdChoice = value;
            }
        }

        // public property for First Price
        public int FirstPrice
        {
            get
            {
                // get the private data
                return mFirstPrice;
            }
            set
            {
                // set the private data
                mFirstPrice = value;
            }
        }

        // public property for Second Price
        public int SecondPrice
        {
            get
            {
                // get the private data
                return mSecondPrice;
            }
            set
            {
                // set the private data
                mSecondPrice = value;
            }
        }

        // public propety for Third Price
        public int ThirdPrice
        {
            get
            {
                // get the private data
                return mThirdPrice;
            }
            set
            {
                // set the private data 
                mThirdPrice = value;
            }
        }

        // public property for Order Total
        public int OrderTotal
        {
            get
            {
                // get the private data
                return mOrderTotal;
            }
            set
            {
                // set the private data
                mOrderTotal = value;
            }
        }

        // public property for Find function
        public bool Find(int OrderNo)
        {
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // add the parameter OrderNo
            DB.AddParameter("@OrderNo", OrderNo);
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            // if the count of records from the database is equal to 1
            if (DB.Count == 1)
            {
                // get the data from the database
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
            // otherwise
            else
            {
                // return false
                return false;
            }

            
        }



        // validation method for order
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
                // store the temporary variable as an integer value
                FirstPriceTemp = Convert.ToInt32(firstPrice);
                // if first price is less than 1
                if (FirstPriceTemp < 1)
                {
                    // return error message
                    Error = Error + "The price cannot be less than £1 : ";
                }

                // if the first price is more than 10
                if (FirstPriceTemp > 10)
                {
                    // return error message
                    Error = Error + "The price cannot be more than £10 : ";
                }

                // store the temporary variable as an integer value
                SecondPriceTemp = Convert.ToInt32(secondPrice);
                // if the second price is less than 1
                if (SecondPriceTemp < 1)
                {
                    // return error message
                    Error = Error + "The price cannot be less than £1 : ";
                }

                // if the second price is more than 10
                if (SecondPriceTemp > 10)
                {
                    // return error message
                    Error = Error + "The price cannot be more than £10 : ";
                }

                // store the temporary variable as a integer value
                ThirdPriceTemp = Convert.ToInt32(thirdPrice);
                if (ThirdPriceTemp < 1)
                {
                    // return error message
                    Error = Error + "The price cannot be less than £1 : ";
                }

                // if the third price is more than 10
                if (ThirdPriceTemp > 10)
                {
                    // return error message
                    Error = Error + "The price cannot be more than £10 : ";
                }

                // store the temporary variable as an integer value
                OrderTotalTemp = Convert.ToInt32(orderTotal);
                // if the order total is less than 1
                if (OrderTotalTemp < 1)
                {
                    // return error message
                    Error = Error + "The total cannot be less than £1 : ";
                }

                // if the order total is more than 30
                if (OrderTotalTemp > 30)
                {
                    // return error message
                    Error = Error + "The total cannot be more than £30 : ";
                }
            }
            // catch the data
            catch
            {
                // record the error
                Error = Error + "The price was not a valid price : ";
            }
            // return error message
            return Error;
        }
    }
}