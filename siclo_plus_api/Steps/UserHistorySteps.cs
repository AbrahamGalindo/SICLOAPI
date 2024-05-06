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
    public class UserHistorySteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public static string id;
        public UserHistorySteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }
        [Given(@"Send the get request for users_history (.*)")]
        public void GivenSendTheGetRequestForUsers_History(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"user/history", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"user/history", $"Bearer {token.token}", "plan");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"user/history", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"useesr/history", $"Bearer {token.token}", "");
                    break;
            }
        }
        [Given(@"Send the post request for users_history (.*)")]
        public void GivenSendThePostRequestForUsers_History(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.PostRequest(UserHistory.GenerateJSONForPostUserHistory(), baseUrl + $"user/history", $"Bearer {token.token}", false);
                    break;
                case 400:
                    rest.PostRequest("{}", baseUrl + $"user/history", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PostRequest(UserHistory.GenerateJSONForPostUserHistory(), baseUrl + $"user/history", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PostRequest(UserHistory.GenerateJSONForPostUserHistory(), baseUrl + $"userwe/history", $"Bearer {token.token}", false);
                    break;
            }
        }

    }
}
