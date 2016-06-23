using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Threading;
using FrameworkUIAutomation;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Protractor;
using TechTalk.SpecFlow;

namespace FrameworkUIAutomation.Pages
{
    public class ToolbarPage
    {
        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_ctl19_DXI0_T")]
        public IWebElement NewBtn;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_ctl19_DXI1_T")]
        public IWebElement DeleteBtn;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_ctl19_DXI4_T")]
        public IWebElement RefreshBtn;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_ctl19_DXI5_T")]
        public IWebElement CloseBtn;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_ctl18_DXI0_T")]
        public IWebElement SaveBtn;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_ctl18_DXI2_T")]
        public IWebElement SaveNCloseBtn;

        [FindsBy(How = How.Id, Using = "popupControlConfirmation_confboxMessageYes")]
        public IWebElement DeleteConfirmationBtn;

        public void CreateNew(NgWebDriver driver)
        {
            //var js = driver.WrappedDriver as IJavaScriptExecutor;
            //js.ExecuteScript("javascript:LoadChildWindow(\'http://itm-dev.dev.itmagnet.biz/blank/user/views/userdetail.aspx?iconurl=~/icons/menu/admin/users_48.png&mtbparentframeid=tab1466489093722&mtbframeid=&CallbackInstance=GridListView038892f6&ImmediateUpdate=True\',0,0,\'\');");

            //driver.SwitchTo().Frame(driver.FindElement(By.TagName("iframe")));
            UIHelper.ClickOnLink(NewBtn);
            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame(1);
        }

        public void RefreshPage()
        {
            UIHelper.ClickOnLink(RefreshBtn);
        }

        public void Save(NgWebDriver driver)
        {
            UIHelper.ClickOnLink(SaveBtn);
            Thread.Sleep(5000);
        }

        public void SaveNClose(NgWebDriver driver)
        {
            UIHelper.ClickOnLink(SaveNCloseBtn);
        }

        public void Delete(NgWebDriver driver)
        {
            UIHelper.ClickOnLink(DeleteBtn);
            UIHelper.ClickOnLink(DeleteConfirmationBtn);
            Thread.Sleep(2000);

            /*var i = 0;
            while (i++ < 5)
            {
                try
                {
                    driver.SwitchTo().Alert().Accept();
                    Thread.Sleep(4000);
                    break;
                }
                catch (Exception)
                {                   
                    Thread.Sleep(1000);
                    continue;
                }
            }*/
        }
    }
}
