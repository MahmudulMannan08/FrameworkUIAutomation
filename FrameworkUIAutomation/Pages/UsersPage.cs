using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using FrameworkUIAutomation;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Protractor;
using TechTalk.SpecFlow;

namespace FrameworkUIAutomation.Pages
{
    public class UsersPage : TestBase
    {
        public static string FirstName, LastName, MiddleName, password;

        public static LoginPage loginpage;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_callbackPanel_aspxFormLayout_txtFirstName_I")]
        public IWebElement FirstNametxt;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_callbackPanel_aspxFormLayout_txtMiddleName_I")]
        public IWebElement MiddleNametxt;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_callbackPanel_aspxFormLayout_txtLastName_I")]
        public IWebElement LastNametxt;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_callbackPanel_aspxFormLayout_txtEmail_I")]
        public IWebElement Emailtxt;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_callbackPanel_aspxFormLayout_txtPhone_I")]
        public IWebElement BusinessPhonetxt;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_callbackPanel_aspxFormLayout_txtMobile_I")]
        public IWebElement Mobiletxt;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_callbackPanel_aspxFormLayout_RoleAssociation1_cpbGroupDetailsControl_gvRoles_cell0_1_chkIsChecked_S_D")]
        public IWebElement RolesChkbox;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_callbackPanel_aspxFormLayout_LoginCredential1_cbpLoginCredential_aspxFormLayoutLoginCredentail_txtUserName_I")]
        public IWebElement Usernametxt;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_callbackPanel_aspxFormLayout_LoginCredential1_cbpLoginCredential_aspxFormLayoutLoginCredentail_PasswordControl1_cbpPassword_aspxFormLayoutPasswordControl_txtPassword_I")]
        public IWebElement Passwordtxt;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_callbackPanel_aspxFormLayout_LoginCredential1_cbpLoginCredential_aspxFormLayoutLoginCredentail_PasswordControl1_cbpPassword_aspxFormLayoutPasswordControl_txtRetypePassword_I")]
        public IWebElement ConfirmPasswordtxt;

        //[FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_callbackPanel_aspxFormLayout_imgUser_aspxPhotoUploadControl_TextBox0_Input")]
        [FindsBy(How = How.CssSelector, Using = "#ctl00_cphSiteMaster_aspxSplitter_callbackPanel_aspxFormLayout_imgUser_aspxPhotoUploadControl_TextBox0_Input")]
        public IWebElement UploadImageBtn;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_ctl21_DXFREditorcol2_I")]
        public IWebElement UsernameSearchtxt;

        //[FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_aspxSplitter_ctl21_DXSelBtn0_D")]
        [FindsBy(How = How.CssSelector, Using = "#ctl00_cphSiteMaster_aspxSplitter_ctl21_DXSelBtn0_D")]
        public IWebElement SelectUser;

        public void EnterName()
        {
            FirstName = RandomString(5);
            LastName = RandomString(5);
            MiddleName = RandomString(2);

            UIHelper.EnterText(FirstNametxt, FirstName);
            UIHelper.EnterText(LastNametxt, LastName);
            UIHelper.EnterText(MiddleNametxt, MiddleName);
        }

        public void EnterEmail()
        {
            UIHelper.EnterText(Emailtxt, "itmagnettest1" + FirstName + LastName + "@gmail.com");
        }

        public void EnterPhone()
        {
            Random rnd = new Random();
            var businessPhone = "04" + rnd.Next(00000000, 99999999);
            var mobile = "04" + rnd.Next(00000000, 99999999);
            UIHelper.EnterText(BusinessPhonetxt, businessPhone);
            UIHelper.EnterText(Mobiletxt, mobile);
        }

        public void SetRole()
        {
            UIHelper.SetCheckbox(RolesChkbox, "ON");
            Thread.Sleep(3000);
        }

        public void EnterPassword()
        {
            password = "itmagnet03";
            UIHelper.EnterText(Passwordtxt, password);
            UIHelper.EnterText(ConfirmPasswordtxt, password);
        }

        public void UserName()
        {
            UIHelper.EnterText(Usernametxt, FirstName);
        }

        public void UploadImage()
        {
            UIHelper.ClickOnLink(UploadImageBtn);
            Thread.Sleep(2000);
            System.Windows.Forms.SendKeys.SendWait("D:\\Personal\\Pic\\KFC.jpg");
            Thread.Sleep(1000);
            System.Windows.Forms.SendKeys.SendWait("{ENTER}");
            Thread.Sleep(4000);
        }

        public void VerifyUserLoggedin()
        {
            UIHelper.EnterText(UsernameSearchtxt, FirstName + " " + LastName + Keys.Enter);
        }

        public void SearchNewUser()
        {
            Thread.Sleep(2000);
            UIHelper.EnterText(UsernameSearchtxt, FirstName + Keys.Enter);
            Thread.Sleep(1000);
            UIHelper.SetCheckbox(SelectUser, "ON");
        }

        public void LoginNewUser()
        {
            loginpage = UIHelper.PageInit<LoginPage>(driver);
            UIHelper.EnterText(loginpage.UserName, FirstName);
            UIHelper.SetCheckbox(loginpage.RememberMeBtn, "OFF");
            UIHelper.EnterText(loginpage.Password, password + Keys.Enter);
        }
    }
}
