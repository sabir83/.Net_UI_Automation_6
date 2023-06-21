using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace _NET_UI_Automation_6.scripts
{
	public class FooterTest : BaseTest
	{
		[Test]
		public void ValidateTheFooter()
		{
            IWebElement addressText = driver.FindElement(By.XPath("(//div[@class='has-text-centered']//p)[1]"));
            IList<IWebElement> socialMediaIcons = driver.FindElements(By.CssSelector(".Footer_socials__7h4n1 a"));

            Assert.That(addressText.Text, Is.EqualTo("2860 S River Rd Suite 480, Des Plaines, IL 60018"));
            //Assert.That(addressText.Text.Equals("2860 S River Rd Suite 480, Des Plaines, IL 60018"));

            for (int i = 0; i < socialMediaIcons.Count; i++)
            {
                Assert.That(socialMediaIcons[i].Displayed);
                Assert.That(socialMediaIcons[i].Enabled);
            }

        }
    }
}
