using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace HomeAppliancesCostNew.StepDefinitions
{
    [Binding]
    public class NorthernIrelandCustomerStepDefinitions
    {
        IWebDriver driver;
        [Given(@"I am a resident from Northern Ireland")]
        public void GivenIAmAResidentFromNorthernIreland()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.citizensadvice.org.uk/");
        }

        [When(@"I select This advice applies to Northern Ireland")]
        public void WhenISelectThisAdviceAppliesToNorthernIreland()
        {
            
        }

        [Then(@"I should get the results message as ‘The advice on this website doesn’t cover Northern Ireland’")]
        public void ThenIShouldGetTheResultsMessageAsTheAdviceOnThisWebsiteDoesnTCoverNorthernIreland()
        {
           
        }
    }
}
