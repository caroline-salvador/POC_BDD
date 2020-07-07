using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Xunit;

namespace BDD
{
    [Binding]
    public class WikipediaStockValidationSteps
    {
        private readonly IWebDriver _webDriver;

        public WikipediaStockValidationSteps(ScenarioContext scenarioContext)
        {
            _webDriver = scenarioContext["WEB_DRIVER"] as IWebDriver;
        }

        [Then(@"the NASDAQ stock symbol on the page should be ""(.*)""")]
        public void ThenTheNASDAQStockSymbolOnThePageShouldBe(string symbol)
        {
            var selector = By.XPath($"//a[@href=\"https://www.nasdaq.com/symbol/{symbol.ToLower()}\"]");
            var element = _webDriver.FindElement(selector);
            Assert.NotNull(element);
        }
    }
}
