using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace BDD
{
    [Binding]
    public class WikipediaSteps
    {
        private readonly IWebDriver _webDriver;
        public WikipediaSteps(ScenarioContext scenarioContext)
        {
            _webDriver = scenarioContext["WEB_DRIVER"] as IWebDriver;
        }

        [Given(@"que naveguei para a página ""(.*)"" da Wikipedia")]
        public void GivenQueNavegueiParaAPaginaDaWikipedia(string url)
        {
            _webDriver.Url = url;
        }
        
        [Then(@"o título da página deve conter ""(.*)""")]
        public void ThenOTituloDaPaginaDeveConter(string p0)
        { 
            var input = _webDriver.FindElement(By.Name("search"));
            input.SendKeys("google");

            var button = _webDriver.FindElement(By.Id("submit"));
            button.Submit();

        }
    }
}
