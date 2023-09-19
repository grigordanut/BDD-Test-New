using System;
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
            driver.Manage().Window.Maximize();
        }

        [When(@"I add the list appliance ""([^""]*)"" average use (.*), (.*), ""([^""]*)"", (.*), and its average usage and the national average rates")]
        public void WhenIAddTheListApplianceAverageUseAndItsAverageUsageAndTheNationalAverageRates(string p0, int p1, int p2, string week, int p4)
        {
            throw new PendingStepException();
        }

        [Then(@"I should get the results table with daily, weekly, monthly, and yearly costs is")]
        public void ThenIShouldGetTheResultsTableWithDailyWeeklyMonthlyAndYearlyCostsIs()
        {
            throw new PendingStepException();
        }
    }
}
