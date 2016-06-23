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
using FrameworkUIAutomation.Pages;
using FrameworkUIAutomation;
using TechTalk.SpecFlow;

namespace FrameworkUIAutomation.Steps
{
    public class CreateNewUser : TestBase
    {
        public static HomePage homepage;
        public static ToolbarPage toolbarpage;
        public static UsersPage userpage;
        public static AuditPage auditpage;

        [Then(@"I go to user list page")]
        public void ThenIGoToUserListPage()
        {
            homepage = UIHelper.PageInit<HomePage>(driver);
            homepage.goToUsersPage(driver);
        }

        [Then(@"I go to create new page")]
        public void ThenIGoToCreateNewPage()
        {
            toolbarpage = UIHelper.PageInit<ToolbarPage>(driver);
            toolbarpage.CreateNew(driver);
        }

        [Then(@"I create a new user")]
        public void ThenICreateANewUser()
        {
            userpage = UIHelper.PageInit<UsersPage>(driver);
            userpage.EnterName();
            userpage.EnterEmail();
            userpage.EnterPhone();
            userpage.SetRole();
            userpage.EnterPassword();
            userpage.UserName();
            //userpage.UploadImage();

            toolbarpage = UIHelper.PageInit<ToolbarPage>(driver);
            toolbarpage.Save(driver);
        }

        [Then(@"I search new user")]
        public void ThenISearchNewUser()
        {
            userpage.SearchNewUser();
        }

        [Then(@"I delete new user")]
        public void ThenIDeleteNewUser()
        {
            toolbarpage.Delete(driver);
        }

        [Then(@"I login with new user")]
        public void ThenILoginWithNewUser()
        {
            userpage = UIHelper.PageInit<UsersPage>(driver);
            userpage.LoginNewUser();
        }

        [Then(@"I go to audit page")]
        public void ThenIGoToAuditPage()
        {
            homepage = UIHelper.PageInit<HomePage>(driver);
            homepage.goToAuditPage(driver);
        }

        [Then(@"I go to user authentication log page")]
        public void ThenIGoToUserAuthenticationLogPage()
        {
            auditpage = UIHelper.PageInit<AuditPage>(driver);
            auditpage.goToAuthenticationPage();
        }

        [Then(@"I go to user session log page")]
        public void ThenIGoToUserSessionLogPage()
        {
            auditpage.goToSessionLogPage();
        }

        [Then(@"I delete user log")]
        public void ThenIDeleteUserLog()
        {
            auditpage.DeleteLog();
        }
    }
}
