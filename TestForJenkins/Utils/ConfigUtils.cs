using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;

namespace Task1
{
    public class ConfigUtils
    {
        public static void GoToUrl()
        {
            JsonSettingsFile configData = new JsonSettingsFile(@"..\..\..\Resources\config.json");
            AqualityServices.Browser.Driver.Navigate().GoToUrl(configData.GetValue<string>("baseUrl"));
        }
    }
}
