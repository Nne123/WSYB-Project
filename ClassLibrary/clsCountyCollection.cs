using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsCountyCollection
    {
        //private data member for the allCountes list
        private List<clsCounty> mAllCounties = new List<clsCounty>();


        //public constructor for the class
        public clsCountyCollection()
        {
            //create an instance of the dataconnection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to get the list of data
            DB.Execute("sproc_tblCounty_SelectAll");
            //get the count of records
            Int32 RecordCount = DB.Count;
            //set up the index for the loop
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a new instance of the county class
                clsCounty ACounty = new clsCounty();
                //get the county name
                ACounty.County = DB.DataTable.Rows[Index]["County"].ToString();
                //get the primary key
                ACounty.CountyNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CountyNo"]);
                //add the county to the private data member
                mAllCounties.Add(ACounty);
                //increment the index
                Index++;
            }
        }

        //public property for Count
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAllCounties.Count;
            }
            set
            {
                //we will look at this in a moment!
            }
        }

        //public property for allCounties
        public List<clsCounty> AllCounties
        {
            //getter sends data to requesting code
            get
            {
                //return the private data mamber
                return mAllCounties;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                mAllCounties = value;
            }
        }
    }
}