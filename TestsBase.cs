using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NvoicepayFactorialAutomation;
using NvoicepayFactorialAutomation.Utilities;


namespace NvoicepayFactorialAutomation
{
    [TestClass]
    public class TestsBase
    {

        [TestInitialize]
        public virtual void Init()
        {
            Utilities.Driver.Initialize();
            Initialize.GoTo();
            System.Threading.Thread.Sleep(1000);
        }

        [TestCleanup]
        public void Quit()
        {
            Utilities.Driver.Quit();
        }
    }
}
