using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.IO;
using System.Reflection;

namespace NvoicepayFactorialAutomation
{
    [TestClass]
    public class UnitTest1 : TestsBase
    {
        Stopwatch timer = new Stopwatch();

        [TestMethod]
        public void FactorialOf5()
        {
            // Setting up strings, variables, webdriver and actions object. Some might not be used
            string FactorialInput = "5";
            Actions action1 = new Actions(Utilities.Driver.Instance);
            IJavaScriptExecutor jse = (IJavaScriptExecutor)Utilities.Driver.Instance;

            // Entering the factorial input
            var EnterIntegerField = Utilities.Driver.Instance.FindElement(By.XPath("//*[@id='number']"));
            EnterIntegerField.SendKeys(FactorialInput);
            System.Threading.Thread.Sleep(1000);

            // Clicking the calculate button
            var CalculateButton = Utilities.Driver.Instance.FindElement(By.XPath("//*[@id='getFactorial']"));
            CalculateButton.Click();
            System.Threading.Thread.Sleep(1000);

            // Verifying that the correct string with the correct value is output
            timer.Restart();
            while (timer.ElapsedMilliseconds < 5000)
            {
                try
                {
                    Utilities.Driver.Instance.FindElement(By.XPath(".//*[contains(text(),'The factorial of 5 is: 120')]")).Click();
                    break;
                }
                catch (Exception e) { }
            }
            IWebElement FactorialExists = Utilities.Driver.Instance.FindElement(By.XPath(".//*[contains(text(),'The factorial of 5 is: 120')]"));
            Assert.IsTrue(FactorialExists.Displayed);
                                 
        }
    }

}
