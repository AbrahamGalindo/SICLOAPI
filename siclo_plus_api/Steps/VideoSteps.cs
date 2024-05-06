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
    public class VideoSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public static string id;
        public VideoSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }

        [Given(@"Send the get request for video (.*)")]
        public void GivenSendTheGetRequestForVideo(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"video", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"video", $"Bearer {token.token}", "403");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"video", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"videoss", $"Bearer {token.token}", "");
                    break;
            }
        }
    }
}
