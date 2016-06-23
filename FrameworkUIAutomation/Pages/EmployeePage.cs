using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FrameworkUIAutomation.Pages
{
    public class EmployeePage : TestBase
    {
        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_ctl00_aspxSplitter_callbackPanel_aspxFormLayout_ContactGeneralInfo1_aspxFormLayoutContact_txtFirstName_I")]
        public IWebElement FirstNametxt;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_ctl00_aspxSplitter_callbackPanel_aspxFormLayout_ContactGeneralInfo1_aspxFormLayoutContact_txtMiddleName_I")]
        public IWebElement MiddleNametxt;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_ctl00_aspxSplitter_callbackPanel_aspxFormLayout_ContactGeneralInfo1_aspxFormLayoutContact_txtLastName_I")]
        public IWebElement LastNametxt;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_ctl00_aspxSplitter_callbackPanel_aspxFormLayout_ContactGeneralInfo1_aspxFormLayoutContact_dteDOB_B-1")]
        public IWebElement DOBDropdownBtn;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_ctl00_aspxSplitter_callbackPanel_aspxFormLayout_ContactGeneralInfo1_aspxFormLayoutContact_dteDOB_DDD_C_BT")]
        public IWebElement DOBCurrentDateBtn;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_ctl00_aspxSplitter_callbackPanel_aspxFormLayout_CountryAndStateSelection1_cbpCountryAndStateSelection_aspxFormLayout_txtCity_I")]
        public IWebElement Citytxt;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_ctl00_aspxSplitter_callbackPanel_aspxFormLayout_cboRegion_B-1")]
        public IWebElement RegionDropdownBtn;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_ctl00_aspxSplitter_callbackPanel_aspxFormLayout_cboRegion_DDD_L_LBI0T0")]
        public IWebElement Region1stSelection;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_ctl00_aspxSplitter_callbackPanel_aspxFormLayout_ctlSupervisor_aspxButtonEdit_B1")]
        public IWebElement SupervisorSearchBtn;

        [FindsBy(How = How.Id, Using = "ctl00_cphSiteMaster_ctl00_aspxSplitter_callbackPanel_aspxFormLayout_CostCenterRecordLookup_aspxButtonEdit_B1")]
        public IWebElement CostCentreSearchBtn;
    }
}
