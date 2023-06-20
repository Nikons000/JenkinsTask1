using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Task1
{
    public class HomePage : Form
    {
        private ILink GoToNextPage => ElementFactory.GetLink(By.CssSelector("[href *= game]"), "GO to the next page");

        public HomePage() : base(By.CssSelector(".start__paragraph:first-of-type"), "Home Page")
        {
        }
        public void ClickGoToNextPage()
        {
            GoToNextPage.Click();
        }
    }
}
