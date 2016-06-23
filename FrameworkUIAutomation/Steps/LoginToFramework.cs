using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System.Threading;
using FrameworkUIAutomation;
using FrameworkUIAutomation.Pages;

namespace FrameworkUIAutomation.Steps
{
    [Binding]
    public class LoginToFramework : TestBase
    {
        public static LoginPage loginPage;
        public static HomePage homepage;

        [Given(@"I am on itmagnet framework landing page")]
        public void GivenIAmOnItmagnetFrameworkLandingPage()
        {
            driver.IgnoreSynchronization = true;

            if (FeatureContext.Current.ContainsKey("error"))
            {
                return;
            }

            UIHelper.GoTo<LoginPage>(HostUrl, false);
        }

        [Then(@"I provide my (.*) and (.*) and (.*) and press login button")]
        public void ThenIProvideMyAndAndAndPressLoginButton(string username, string password, bool remember)
        {
            loginPage = UIHelper.PageInit<LoginPage>(driver);
            loginPage.ProvideCredentials(username, password, remember);
            Thread.Sleep(1000);
        }

        [Then(@"Verify I am on framework homepage and (.*) is visible when my logged in state (.*)")]
        public void ThenVerifyIAmOnFrameworkHomepageAndIsVisibleWhenMyLoggedInState(string model, bool logged)
        {
            if (logged)
            {
                homepage = UIHelper.PageInit<HomePage>(driver);
                Assert.That(homepage.verifyPrototypeMenuVisible(driver), Is.EqualTo(model));
            }
            else
            {
                Assert.False(homepage.userIsLogged(driver));
            }
        }


        [Then(@"I logout")]
        public void ThenILogout()
        {
            loginPage = UIHelper.PageInit<LoginPage>(driver);
            loginPage.Logout(driver);
            Thread.Sleep(1000);
        }

    }
}
