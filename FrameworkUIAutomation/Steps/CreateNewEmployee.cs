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
using FrameworkUIAutomation.Pages;
using FrameworkUIAutomation;
using TechTalk.SpecFlow;

namespace FrameworkUIAutomation.Steps
{
    [Binding]
    public class CreateNewEmployee : TestBase
    {
        public static HomePage homepage;

        [Then(@"I go to employee list page")]
        public void ThenIGoToEmployeeListPage()
        {
            homepage = UIHelper.PageInit<HomePage>(driver);
            homepage.goToEmployeePage(driver);
        }

        [Then(@"I create a new employee")]
        public void ThenICreateANewEmployee()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I add employee address")]
        public void ThenIAddEmployeeAddress()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I add employee note")]
        public void ThenIAddEmployeeNote()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I add employee document")]
        public void ThenIAddEmployeeDocument()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I add employee license")]
        public void ThenIAddEmployeeLicense()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I add employee communication")]
        public void ThenIAddEmployeeCommunication()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I search new employee")]
        public void ThenISearchNewEmployee()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I delete new employee")]
        public void ThenIDeleteNewEmployee()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
