using System;


namespace ClassLibrary
{
    public class clsCounty
    {
        // var to store the variables
        public string County { get; set; }
        public int CountyNo { get; set; }

        public string Valid(string someCounty)
        {
            // string variables to store the error message
            string Error = "";
            //if the name of the county is more than 50 characters
            if (someCounty.Length > 50)
            {
                //return an error message
                Error = "The county name cannot have more than 50 characters";
            }
            //if the name of the county is 0 characters
            if (someCounty.Length == 0)
            {
                //return an error message
                Error = "The county name may not be blank!";
            }
            return Error;
        }
    }
}