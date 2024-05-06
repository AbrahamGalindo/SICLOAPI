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
    public class ScheduleSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public ScheduleSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }
        [Given(@"Send the get request for schedule (.*)")]
        public void GivenSendTheGetRequestForSchedule(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.GetRequest( baseUrl + $"schedule", $"Bearer {token.token}","");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"schedule", $"Bearer {token.token}", "");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"schedule", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"scheduless", $"Bearer {token.token}", "");
                    break;
            }
        }

        [Given(@"Send the get request for schedule_recent (.*)")]
        public void GivenSendTheGetRequestForSchedule_Recent(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"schedule/recent", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"schedule/recent", $"Bearer {token.token}", "");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"schedule/recent", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"scheduless/recent", $"Bearer {token.token}", "");
                    break;
            }
        }
    }
}
