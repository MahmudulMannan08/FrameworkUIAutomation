using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FrameworkUIAutomation;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Protractor;
using TechTalk.SpecFlow;

namespace FrameworkUIAutomation.Pages
{
    [Binding]
    public class HomePage
    {
        public static HomePage homepage;

        //[FindsBy(How = How.Id, Using = "LayoutSplitter_HomeLinksMenu_DXI7_T")]
        [FindsBy(How = How.ClassName, Using = "dx-vam")]
        public IWebElement myAccountImage;

        [FindsBy(How = How.Id, Using = "mnuGroups_DXI0_T")]
        public IWebElement protoTypeMenu;

        [FindsBy(How = How.Id, Using = "mnuGroups_DXI8_T")]
        public IWebElement SystemSettingsMenuBtn;

        [FindsBy(How = How.Id, Using = "LayoutSplitter_navBarAppMenu_I8i1_T")]
        public IWebElement UsersSubMenuBtn;

        [FindsBy(How = How.Id, Using = "mnuGroups_DXI5_T")]
        public IWebElement HRMMenuBtn;

        [FindsBy(How = How.Id, Using = "LayoutSplitter_navBarAppMenu_I5i0_T")]
        public IWebElement EmployeeSubMenuBtn;

        [FindsBy(How = How.Id, Using = "LayoutSplitter_navBarAppMenu_I8i5_T")]
        public IWebElement AuditSubMenuBtn;

        public string verifyPrototypeMenuVisible(IWebDriver driver)
        {
            var elapsed = 0;
            var timeSpan = 6000;
            //while (driver.PageSource.Contains("LayoutSplitter_HomeLinksMenu_DXI7_T") == false && (elapsed < timeSpan))
            while (driver.PageSource.Contains("mnuGroups_DXI0_T") == false && (elapsed < timeSpan))
            {
                Thread.Sleep(1000);
                elapsed += 1000;
            }

            //return driver.PageSource.Contains("LayoutSplitter_HomeLinksMenu_DXI7_T") ? this.protoTypeMenu.GetAttribute("title") : "No account image found, therefore user is not logged in";
            return driver.PageSource.Contains("mnuGroups_DXI0_T") ? this.protoTypeMenu.GetAttribute("title") : "Model is not visible, therefore user is not logged in";
        }

        public bool userIsLogged(IWebDriver driver)
        {
            var elapsed = 0;
            var timeSpan = 6000;
            while (driver.PageSource.Contains("mnuGroups_DXI0_T") == false && (elapsed < timeSpan))
            {
                Thread.Sleep(1000);
                elapsed += 1000;
            }

            return driver.PageSource.Contains("mnuGroups_DXI0_T") ? true : false;
        }

        public void goToUsersPage(NgWebDriver driver)
        {
            /*Thread.Sleep(1000);
            var js = driver.WrappedDriver as IJavaScriptExecutor;
            js.ExecuteScript("javascript:CloseAllTab();");
            Thread.Sleep(2000);*/

            driver.SwitchTo().DefaultContent();

            UIHelper.ClickOnLink(SystemSettingsMenuBtn);
            UIHelper.ClickOnLink(UsersSubMenuBtn);

            //driver.SwitchTo().Frame(driver.FindElement(By.TagName("iframe")));
            driver.SwitchTo().Frame(0);
        }

        public void goToEmployeePage(NgWebDriver driver)
        {
            driver.SwitchTo().DefaultContent();

            UIHelper.ClickOnLink(HRMMenuBtn);
            UIHelper.ClickOnLink(EmployeeSubMenuBtn);

            driver.SwitchTo().Frame(0);
        }

        public void goToAuditPage(NgWebDriver driver)
        {
            driver.SwitchTo().DefaultContent();

            UIHelper.ClickOnLink(SystemSettingsMenuBtn);
            UIHelper.ClickOnLink(AuditSubMenuBtn);

            driver.SwitchTo().Frame(1);
        }
    }
}
