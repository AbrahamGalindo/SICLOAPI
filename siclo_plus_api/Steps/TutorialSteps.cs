using siclo_plus_api.Helpers;
using siclo_plus_api.Hooks;
using siclo_plus_api.JSON;
using siclo_plus_api.Request;
using System;
using TechTalk.SpecFlow;
using BearerToken = siclo_plus_api.Models.Token;

namespace siclo_plus_api.Steps
{
    [Binding]
    public class TutorialSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public static string id;
        Rest rest = new Rest();
        public TutorialSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }
        [Given(@"Send the get request for tutorial (.*)")]
        public void GivenSendTheGetRequestForTutorial(int response)
        {
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"tutorial", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"tutorial", $"Bearer {token.token}", "403");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"tutorial", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"tutorials", $"Bearer {token.token}", "");
                    break;
            }
        }
        [Given(@"Send the get request for tutorial_id (.*)")]
        public void GivenSendTheGetRequestForTutorial_Id(int response)
        {
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"tutorial/{id}", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"tutorial/{id}", $"Bearer {token.token}", "403");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"tutorial/{id}", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"tutorialess/{id}", $"Bearer {token.token}", "");
                    break;
            }
        }

    }
}
