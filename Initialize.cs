using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvoicepayFactorialAutomation.Utilities
{
    public class Initialize
    {
        public static void GoTo()
        {
            Utilities.Driver.Instance.Navigate().GoToUrl("http://qainterview.pythonanywhere.com/");
        }
    }
}
