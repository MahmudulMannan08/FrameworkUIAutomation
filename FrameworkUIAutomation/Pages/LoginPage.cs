using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FrameworkUIAutomation;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Protractor;

namespace FrameworkUIAutomation.Pages
{
    public class LoginPage : IPage
    {
        [FindsBy(How = How.Id, Using = "roundPanelLogin_itmLoginControl_txtUsername_I")]
        public IWebElement UserName;

        [FindsBy(How = How.Id, Using = "roundPanelLogin_itmLoginControl_txtPassword_I")]
        public IWebElement Password;

        [FindsBy(How = How.Id, Using = "roundPanelLogin_itmLoginControl_btnLogin_CD")]
        public IWebElement LoginBtn;

        [FindsBy(How = How.Id, Using = "roundPanelLogin_itmLoginControl_chkRememberMe_S_D")]
        public IWebElement RememberMeBtn;

        [FindsBy(How = How.Id, Using = "roundPanelLogin_itmLoginControl_hlForgotPasswordCaption")]
        public IWebElement ForgotPswrdBtn;

        public string Url
        {
            get
            {
                return "/";
            }
        }

        public void ProvideCredentials(string user, string pass, bool remember)
        {
            UIHelper.EnterText(this.UserName, user);

            if (remember)
            {
                UIHelper.SetCheckbox(this.RememberMeBtn, "ON");
            }

            UIHelper.EnterText(this.Password, pass + Keys.Enter);
        }

        public void Logout(NgWebDriver driver)
        {
            driver.SwitchTo().DefaultContent();

            var js = driver.WrappedDriver as IJavaScriptExecutor;
            //js.ExecuteScript("javascript: $.Sign out();");
            js.ExecuteScript("javascript:SignoutUser();");
            Assert.IsTrue(this.LoginBtn.Displayed);
        }
    }
}
