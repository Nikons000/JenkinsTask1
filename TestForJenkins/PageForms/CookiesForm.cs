using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Task1
{
    public class CookiesForm : Form
    {
        private IButton AcceptCookies => ElementFactory.GetButton(By.CssSelector("[class *= transparent]"), "Accept Cookies");
        private ILabel CookiesMain => ElementFactory.GetLabel(By.CssSelector(".cookies"), "Form Of Cookies");

        public CookiesForm() : base(By.CssSelector(".cookies"), "Cookies Form")
        {
        }
        public void ClickAcceptCookies()
        {
            AcceptCookies.Click();
        }
        public bool IsCookiesFormClosed()
        {
            return CookiesMain.State.WaitForNotDisplayed();
        }
    }
}
