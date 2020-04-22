using System;

namespace ClassLibrary
{
    public class clsCardDetails
    {
        private Int32 mCardNo;
        private string mCardNo1;

        public int CardNo
        {
            get
            {
                return mCardNo;
            }
            set
            {
                mCardNo = value;
            }
        }

        public string CardNo1
        {
            get
            {
                return mCardNo1;
            }
            set
            {
                mCardNo1 = value;
            }
        }


        






        public bool Find(int CardNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CardNo", CardNo);
            DB.Execute("sproc_tblCardDetails_FilterByCardNo");
            if (DB.Count == 1)
            {
                mCardNo = Convert.ToInt32(DB.DataTable.Rows[0]["CardNo"]);
                mCardNo1 = Convert.ToString(DB.DataTable.Rows[0]["CardNo1"]);

                return true;
            }
            // if no record was found
            else
            {
                // return false indicating a problem
                return false;
            }
        }

        public string Valid(string cardNo1)
        {
            String Error = "";
            // create a temporary variable to store the menu item price

            if (cardNo1.Length < 5)
            {
                Error = Error + "The card no cannot be less than 5 numbers : ";
            }

            if (cardNo1.Length > 10)
            {
                Error = Error + "The card no cannot be more than 10 numbers : ";
            }


            return Error;
        }
    }
}