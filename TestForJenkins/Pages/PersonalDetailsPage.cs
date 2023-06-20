using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Task1
{
    class PersonalDetailsPage : Form
    {
        private ILink GoToNextPage => ElementFactory.GetLink(By.CssSelector("[href *= game]"), "GO to the next page");

        public PersonalDetailsPage() : base(By.CssSelector(".personal-details__tr-row:first-of-type"), "Home Page")
        {
        }
        public void ClickGoToNextPage()
        {
            GoToNextPage.Click();
        }
    }
}
