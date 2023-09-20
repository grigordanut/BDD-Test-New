using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace HomeAppliancesCostNew.StepDefinitions
{
    [Binding]
    public class WalesCustomerStepDefinitions
    {
        IWebDriver driver;
        [Given(@"I am a resident from Wales")]
        public void GivenIAmAResidentFromWales()
        {
            driver = new ChromeDriver();
            //driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.citizensadvice.org.uk/");
            driver.FindElement(By.XPath("//*[@id=\"home-extent-popup\"]/div/div/a[4]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/button")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"main-nav\"]/ul/li[4]/a")).Click();            
            driver.FindElement(By.XPath("//*[@id=\"cads-main-content\"]/div/div/div/main/div[1]/nav/ul/li/a")).Click();
            driver.FindElement(By.XPath("//*[@id=\"cads-main-content\"]/div/div/div/main/div[1]/nav/ul/li[6]/a")).Click();
        }

        [When(@"I add the list appliance ""([^""]*)"" average use (.*), (.*), ""([^""]*)"", (.*), and its average usage and the national average rates")]
        public void WhenIAddTheListApplianceAverageUseAndItsAverageUsageAndTheNationalAverageRates(string appliance, int hours, int minutes, string frequency, int rate)
        {
            SelectElement selecteAppliance = new(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
            selecteAppliance.SelectByText(appliance);
            driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + hours);
            driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + minutes);
            SelectElement selectedFrequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
            selectedFrequency.SelectByValue(frequency);
            driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("" + rate);
            driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
        }

        [Then(@"I should get the results table with daily, weekly, monthly, and yearly costs is")]
        public void ThenIShouldGetTheResultsTableWithDailyWeeklyMonthlyAndYearlyCostsIs()
        {
            string actual = driver.FindElement(By.XPath("//*[@id=\"RootPlaceHolder_RootPlaceHolder_SubHeading\"]/span")).Text;
            Console.WriteLine(actual);
            String expected = "This advice applies to Wales";
            Assert.AreEqual(actual, expected);
            driver.FindElement(By.XPath("//*[@id=\"appliance_running\"]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"reset\"]")).Click();
            driver.SwitchTo().Alert().Accept();
            driver.Quit();
        }
    }
}
