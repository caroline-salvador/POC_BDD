using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BDD
{
    [Binding]
    class Test
    {
        [Before]
        public void CreateWebDriver(ScenarioContext context)
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--desable-notifications");

            IWebDriver webDriver = new ChromeDriver(options);
            context["WEB_DRIVER"] = webDriver;
        }

        [After]
        public void CloseWebDriver(ScenarioContext context)
        {
            var driver = context["WEB_DRIVER"] as IWebDriver;
            driver.Quit();
        }
    }
}
