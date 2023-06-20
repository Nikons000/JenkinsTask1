using Aquality.Selenium.Browsers;
using NUnit.Framework;

namespace Task1
{
    [TestFixture]
    public class TestClass
    {

        [SetUp]
        public void BeforeTest()
        {
            ConfigUtils.GoToUrl();
            AqualityServices.Browser.Maximize();
        }

        [Test]
        public void VerifyHomePageAndClickGoToNextPageLink()
        {
            var randomUtil = new RandomUtil();
            var homePage = new HomePage();
            var testData = new TestData();
            Assert.That(homePage.State.WaitForDisplayed());
            homePage.ClickGoToNextPage();
            var loginPage = new LoginPage();
            Assert.That(loginPage.State.WaitForDisplayed());
            loginPage.InputEmail(randomUtil.GenerateRandomLogin());
            loginPage.InputPassword(randomUtil.GenerateRandomPassword());
            loginPage.InputDomain(testData.GetDomain());
            loginPage.ClickDropDownTLD();
            loginPage.ClickTLD(testData.GetTld());
            loginPage.ClickTermsAndConditionsCheckBox();
            loginPage.ClickNext();
            var thisIsMePage = new ThisIsMePage();
            Assert.That(thisIsMePage.State.WaitForDisplayed());
            thisIsMePage.ClickOnRandomInterests();
            thisIsMePage.ClickImageUpload();
            thisIsMePage.NewImageUpload();
            thisIsMePage.ClickNext();
            var personalDetailsPage = new PersonalDetailsPage();
            Assert.That(personalDetailsPage.State.WaitForDisplayed());
        }
        [Test]
        public void HelpForm()
        {
            var homePage = new HomePage();
            Assert.That(homePage.State.WaitForDisplayed());
            homePage.ClickGoToNextPage();
            var loginPage = new LoginPage();
            Assert.That(loginPage.State.WaitForDisplayed());
            loginPage.helpForm.ClickHideHelp();
            Assert.That(loginPage.helpForm.CheckHelpFormHidden());
        }
        [Test]
        public void Cookies()
        {
            var homePage = new HomePage();
            Assert.That(homePage.State.WaitForDisplayed());
            homePage.ClickGoToNextPage();
            var loginPage = new LoginPage();
            Assert.That(loginPage.State.WaitForDisplayed());
            loginPage.cookiesForm.ClickAcceptCookies();
            Assert.That(loginPage.cookiesForm.IsCookiesFormClosed());
        }
        [Test]
        public void Timer()
        {
            var homePage = new HomePage();
            Assert.That(homePage.State.WaitForDisplayed());
            homePage.ClickGoToNextPage();
            var loginPage = new LoginPage();
            Assert.That(loginPage.State.WaitForDisplayed());
            string timerText = loginPage.timerForm.GetHoursAndMinutes();
            Assert.AreEqual("00:00", timerText);
        }
        [TearDown]
        public void AfterTest()
        {
            AqualityServices.Browser.Quit();
        }
    }
}
