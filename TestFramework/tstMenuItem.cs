using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFramework
{
    [TestClass]
    public class tstMenuItem
    {
        // The class exists

        [TestMethod]
        public void InstanceOK()
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            Assert.IsNotNull(AMenuItem);
        }
    }
}
