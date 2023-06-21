using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace _NET_UI_Automation_6.scripts
{
    [TestFixture]
    public class HeaderTest : BaseTest
    {

        [Test] // Like @Test annotation from TestNG
        public void ValidateLogo()
        {
            // Locate web elements using 8 different locators
            IWebElement logo = driver.FindElement(By.Id("logo"));

            // Assertions
            Assert.That(logo.Displayed);
        }


        [Test]
        public void ValidateThePracticesDropdown()
        {
            IWebElement practicesDropdown = driver.FindElement(By.Id("dropdown-button"));
            IList<IWebElement> dropdownOptions = driver.FindElements(By.CssSelector("#dropdown-menu a"));

            string[] expectedTexts = { "Frontend Testing", "Backend Testing", "Java Exercises", "JS Exercises", "Mock Interviews" };

            Assert.That(practicesDropdown.Displayed);
            Assert.That(practicesDropdown.Text, Is.EqualTo("Practices"));


            Actions actions = new Actions(driver);
            actions.MoveToElement(practicesDropdown).Perform();

            for (int i = 0; i < dropdownOptions.Count; i++)
            {
                Assert.That(dropdownOptions[i].Text, Is.EqualTo(expectedTexts[i]));
            }
        }


    }
}
