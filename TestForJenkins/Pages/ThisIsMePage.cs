using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using WindowsInput;
using WindowsInput.Native;

namespace Task1
{
    public class ThisIsMePage : Form
    {
        Random random = new Random();
        TestData testData = new TestData();
        private IList<ILabel> Interests => ElementFactory.FindElements<ILabel>(By.CssSelector("label:not([for*='select'])"), "Interests");
        private IButton ImageUpload => ElementFactory.GetButton(By.CssSelector(".avatar-and-interests__upload-button"), "Image Upload");
        private IButton UnselectAll => ElementFactory.GetButton(By.CssSelector("[for = interest_unselectall]"), "Unselect All Button");
        private IButton Next => ElementFactory.GetButton(By.CssSelector("[class *= 'button--white button--fluid']"), "Next Button");
        public ThisIsMePage() : base(By.CssSelector("[class *= avatar-box]"), "This is me Page")
        {
        }

        public void ClickOnRandomInterests()
        {
            UnselectAll.Click();

            List<int> randomIndices = Enumerable.Range(0, Interests.Count).ToList();
            randomIndices = randomIndices.OrderBy(i => random.Next()).Take(testData.GetNumberOfInterestsToClick()).ToList();

            foreach (int index in randomIndices)
            {
                Interests[index].Click();
            }
        }

        public void ClickImageUpload()
        {
            ImageUpload.Click();
        }

        public void NewImageUpload()
        {
            var inputSimulator = new InputSimulator();
            inputSimulator.Keyboard.Sleep(800);
            string fullPath = FullPathUtil.GetFullPath(@"Resources\yt_icon_rgb.ico");
            inputSimulator.Keyboard.Sleep(800).TextEntry(fullPath);
            inputSimulator.Keyboard.Sleep(800);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            inputSimulator.Keyboard.Sleep(800);
        }

        public void ClickNext()
        {
            Next.WaitAndClick();
        }
    }
}
