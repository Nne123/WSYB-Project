using System;

namespace ClassLibrary
{
    public class clsCounty
    {
        public string County { get; set; }
        public int CountyNo { get; set; }

        public string Valid(string someCounty)
        {
            string Error = "";

            if (someCounty.Length > 50)
            {
                Error = "The county name cannot have more than 50 characters";
            }
            if (someCounty.Length == 0)
            {
                Error = "The county name may not be blank!";
            }
            return Error;
        }
    }
}