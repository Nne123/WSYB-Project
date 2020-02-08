using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFramework
{
    [TestClass]
    public class tstCounty
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCounty ACounty = new clsCounty();
            Assert.IsNotNull(ACounty);
        }

        [TestMethod]
        public void CountyPropertyOK()
        {
            clsCounty ACounty = new clsCounty();
            string SomeCounty = "Leicestershire";
            ACounty.County = SomeCounty;
            Assert.AreEqual(ACounty.County, SomeCounty);
        }

        [TestMethod]
        public void CountyNoPropertyOK()
        {
            clsCounty ACounty = new clsCounty();
            Int32 CountyNo = 1;
            ACounty.CountyNo = CountyNo;
            Assert.AreEqual(ACounty.CountyNo, CountyNo);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCounty ACounty = new clsCounty();
            String Error = "";
            string SomeCounty = "Leicestershire";
            Error = ACounty.Valid(SomeCounty);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyMinLessOne()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCounty = "";
            //invoke the method
            Error = ACounty.Valid(SomeCounty);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CountyMinBoundary()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCounty = "a";
            //invoke the method
            Error = ACounty.Valid(SomeCounty);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCounty = "aa";
            //invoke the method
            Error = ACounty.Valid(SomeCounty);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCounty = "0123456789012345678901234567890123456789012345678";
            //invoke the method
            Error = ACounty.Valid(SomeCounty);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CountyMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCounty = "01234567890123456789012345678901234567890123456789";
            //invoke the method
            Error = ACounty.Valid(SomeCounty);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCounty = "012345678901234567890123456789012345678901234567890";
            //invoke the method
            Error = ACounty.Valid(SomeCounty);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CountyMid()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCounty = "0123456789012345678901234";
            //invoke the method
            Error = ACounty.Valid(SomeCounty);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyExtremeMax()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCounty = "";
            //pad the string with characters
            SomeCounty = SomeCounty.PadRight(500, 'a');
            //invoke the method
            Error = ACounty.Valid(SomeCounty);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }
    }
}
