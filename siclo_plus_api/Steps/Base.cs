using siclo_plus_api.Helpers;
using TechTalk.SpecFlow;

namespace siclo_plus_api.Steps
{
    public class Base
    {
        protected readonly FeatureContext _featureContext;
        protected readonly ScenarioContext _scenarioContext;
        public static string baseUrl;
        public string data;
        protected int numberScenario;
        public string poolDataName;
        public static string scenarioName;
        public static string spectedResponse;

        public Base(ScenarioContext scenarioContext, FeatureContext featureContext)
        {
            _scenarioContext = scenarioContext;
            _featureContext = featureContext;
        }
    }
}