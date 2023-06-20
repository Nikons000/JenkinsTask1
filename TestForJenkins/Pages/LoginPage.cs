using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Task1
{
    public class LoginPage : Form
    {
        public CookiesForm cookiesForm => new CookiesForm();
        public HelpForm helpForm => new HelpForm();
        public TimerForm timerForm => new TimerForm();

        private ITextBox PasswordField => ElementFactory.GetTextBox(By.CssSelector("[placeholder *= Password]"), "Password Field");
        private ITextBox EmailField => ElementFactory.GetTextBox(By.CssSelector("[placeholder *= email]"), "Email Field");
        private ITextBox DomainField => ElementFactory.GetTextBox(By.CssSelector("[placeholder *= Domain]"), "Domain Field");
        private IButton DropDownTLD => ElementFactory.GetButton(By.CssSelector(".dropdown"), "Drop Down TLD");
        private IButton TermsAndConditionsCheckBox => ElementFactory.GetButton(By.CssSelector(".checkbox"), "Terms and Conditions Checkbox");
        private IButton TLDs(string tld) => ElementFactory.GetButton(By.XPath($"//div[contains(text(), '{tld}')]"), "TLD Button");
        private IButton Next => ElementFactory.GetButton(By.XPath("//a[contains(text(), 'Next')]"), "Next Button");
        public LoginPage() : base(By.CssSelector(".login-form__terms-conditions"), "Login Page")
        {
        }

        public void InputPassword(string password)
        {
            PasswordField.ClearAndType(password);
        }

        public void InputEmail(string email)
        {
            EmailField.ClearAndType(email);
        }

        public void InputDomain(string domain)
        {
            DomainField.ClearAndType(domain);
        }

        public void ClickDropDownTLD()
        {
            DropDownTLD.Click();
        }

        public void ClickTLD(string tld)
        {
            TLDs(tld).Click();
        }

        public void ClickTermsAndConditionsCheckBox()
        {
            TermsAndConditionsCheckBox.Click();
        }

        public void ClickNext()
        {
            Next.Click();
        }
    }
}
