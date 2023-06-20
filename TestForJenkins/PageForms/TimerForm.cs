using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Task1
{
    public class TimerForm : Form
    {
        private ILabel Timer => ElementFactory.GetLabel(By.CssSelector(".timer"), "Timer");

        public TimerForm() : base(By.CssSelector(".timer"), "Timer Form")
        {
        }
        public string GetHoursAndMinutes()
        {
            string fullTimerText = Timer.Text;
            string[] timerParts = fullTimerText.Split(':');
            string hours = timerParts[0];
            string minutes = timerParts[1];

            return $"{hours}:{minutes}";
        }
    }
}
