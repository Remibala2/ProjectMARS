using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARS_QA.Utilities
{
    [Binding]
    public class Start : CommonDriver
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            Initialise();
            TurnOnWait();
            NavigateUrl();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            TurnOnWait();
            Close();
        }

    }
      
}
