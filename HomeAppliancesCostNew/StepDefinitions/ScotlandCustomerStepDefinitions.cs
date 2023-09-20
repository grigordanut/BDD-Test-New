using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace HomeAppliancesCostNew.StepDefinitions
{
    [Binding]
    public class ScotlandCustomerStepDefinitions
    {
        IWebDriver driver;
        [Given(@"I am a resident from Scotland")]
        public void GivenIAmAResidentFromScotland()
        {
            driver = new ChromeDriver();
            //driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.citizensadvice.org.uk/");
            driver.FindElement(By.XPath("//*[@id=\"home-extent-popup\"]/div/div/a[3]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/button")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"main-nav\"]/ul/li[4]/a")).Click();            
            driver.FindElement(By.XPath("//*[@id=\"cads-main-content\"]/div/div/div/main/div[1]/nav/ul/li/a")).Click();            
            driver.FindElement(By.XPath("//*[@id=\"cads-main-content\"]/div/div/div/main/div[1]/nav/ul/li[6]/a")).Click();
        }

        [When(@"I add the list appliances ""([^""]*)"" average use (.*), (.*), ""([^""]*)"", (.*), and its average usage and the national average rates")]
        public void WhenIAddTheListAppliancesAverageUseAndItsAverageUsageAndTheNationalAverageRates(string appliance, int hours, int minutes, string frequency, int rate)
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

        [Then(@"I should get the results table with daily, weekly, monthly, and yearly costs")]
        public void ThenIShouldGetTheResultsTableWithDailyWeeklyMonthlyAndYearlyCosts()
        {
            string actual = driver.FindElement(By.XPath("//*[@id=\"RootPlaceHolder_RootPlaceHolder_SubHeading\"]/span")).Text;
            Console.WriteLine(actual);
            String expected = "This advice applies to Scotland";
            Assert.AreEqual(actual, expected);
            driver.FindElement(By.XPath("//*[@id=\"appliance_running\"]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"reset\"]")).Click();
            driver.SwitchTo().Alert().Accept();
            driver.Quit();
        }
    }
}
