using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Task1
{
    public class HelpForm : Form
    {
        private IButton HideHelp => ElementFactory.GetButton(By.CssSelector("[class *= send]"), "Hide Help Form Button");
        private ILabel HiddenStatus => ElementFactory.GetLabel(By.CssSelector("[class *= title]"), "Check That Help Form Is Hidden ");

        public HelpForm() : base(By.CssSelector("[class *= send]"), "Help Form")
        {
        }
        public void ClickHideHelp()
        {
            HideHelp.Click();
        }
        public bool CheckHelpFormHidden()
        {
            return HiddenStatus.State.WaitForNotDisplayed();
        }
    }
}
