using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FrameworkUIAutomation.Pages
{
    public class AuditPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_ctl26_ctl18")]
        public IWebElement AuthenticationLogBtn;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_ctl25_ctl18")]
        public IWebElement SessionLogBtn;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_ctl19_DXI0_T")]
        public IWebElement LogDeleteBtn;

        [FindsBy(How = How.Id, Using = "popupControlConfirmation_confboxMessageYes_CD")]
        public IWebElement LogDelConfirmBtn;

        public void goToAuthenticationPage()
        {
            UIHelper.ClickOnLink(AuthenticationLogBtn);
            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame(2);
        }

        public void goToSessionLogPage()
        {
            UIHelper.ClickOnLink(SessionLogBtn);
            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame(3);
        }

        public void DeleteLog()
        {
            UIHelper.ClickOnLink(LogDeleteBtn);
            UIHelper.ClickOnLink(LogDelConfirmBtn);
        }

    }
}
