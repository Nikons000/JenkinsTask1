using Aquality.Selenium.Core.Utilities;

namespace Task1
{
    public class TestData
    {
        JsonSettingsFile testData = new JsonSettingsFile(@"..\..\..\Resources\testData.json");
        public string GetDomain()
        {
            return testData.GetValue<string>("domain");
        }
        public string GetTld()
        {
            return testData.GetValue<string>("tld");
        }
        public int GetNumberOfInterestsToClick()
        {
            return testData.GetValue<int>("interestsToClick"); ;
        }
    }
}
