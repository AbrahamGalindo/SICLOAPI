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
    public class UserExternalServicesSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public static string id;
        public UserExternalServicesSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }
        [Given(@"Send the get request for users_services (.*)")]
        public void GivenSendTheGetRequestForUsers_Services(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"user/services", $"Bearer {token.token}", "plan");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"user/services", $"Bearer {token.token}", "");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"user/services", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"useres/services", $"Bearer {token.token}", "");
                    break;
            }
        }

        [Given(@"Send the post request for users_services (.*)")]
        public void GivenSendThePostRequestForUsers_Services(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.PostRequest(UserExternalService.GenerateJSONForPostUserExternalServices(),baseUrl + $"user/services", $"Bearer {token.token}", false);
                    break;
                case 400:
                    rest.PostRequest("",baseUrl + $"user/services", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PostRequest("",baseUrl + $"user/services", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PostRequest("",baseUrl + $"useres/services", $"Bearer {token.token}", false);
                    break;
            }
        }

    }
}
