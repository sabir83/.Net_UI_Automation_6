using _NET_UI_Automation_6.pages;
using NUnit.Framework;
using OpenQA.Selenium;


namespace _NET_UI_Automation_6.scripts
{
    public class MOckInterviewsTest : BaseTest
    {
        [SetUp]
        public void SetPage()
        {
            
            mockInterviewsPage = new MockInterviewsPage();
            actions.MoveToElement(mockInterviewsPage.practicesDropdown).Perform();
            mockInterviewsPage.dropdownOptions[4].Click();
        }
        [Test]
        public void ValidateTheHeader()
        {
            
            Assert.That(mockInterviewsPage.element.Text, Is.EqualTo("Designed for TechGlobal Students"));
        }
        /*
        Go to "https://techglobal-training.com/"
        Click on "Mock Interviews" from "Practices" dropdown
        Enter username as "john"
        Enter password as "1234"
        Validate the error message is "Email or Password does not much!"
         */

        [Test]
        [TestCase("john", "1234")]
        [TestCase("techglobal", "2020")]
        [TestCase("okan", "1234test")]
        public void ValidateLoginFormErrorMessage(string username, string password)
        {
            mockInterviewsPage.usernameInputBox.SendKeys(username);
            mockInterviewsPage.passwordInputBox.SendKeys(password + Keys.Enter);
            
            Assert.That(mockInterviewsPage.errorMessage.Text, Is.EqualTo("Email or Password does not much!")); 
        }
    }
}

