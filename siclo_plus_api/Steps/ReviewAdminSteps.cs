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
    public class ReviewAdminSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        Rest rest = new Rest();
        public ReviewAdminSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }
        [Given(@"Send the get request for review (.*)")]
        public void GivenSendTheGetRequestForReview(int response)
        {
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"review", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"review", $"Bearer {token.token}", "403");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"review", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"reviewes", $"Bearer {token.token}", "");
                    break;
            }
        }
        [Given(@"Send the get request for review_id (.*)")]
        public void GivenSendTheGetRequestForReview_Id(int response)
        {
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"review/6b2420bf-61a4-4037-9471-2333429dfcb1", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"review/6b2420bf-61a4-4037-9471-2333429dfcb1", $"Bearer {token.token}", "403");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"review/6b2420bf-61a4-4037-9471-2333429dfcb1", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"reviewes/6b2420bf-61a4-4037-9471-2333429dfcb1", $"Bearer {token.token}", "");
                    break;
            }
        }

        [Given(@"Send the put request for review_id (.*)")]
        public void GivenSendThePutRequestForReview_Id(int response)
        {
            switch (response)
            {
                case 200:
                    rest.PutRequest(ReviewAdmin.GenerateJSONForPostReview(), baseUrl + $"review/6b2420bf-61a4-4037-9471-2333429dfcb1", $"Bearer {token.token}", false);
                    break;
                case 400:
                    rest.PutRequest("[{}]", baseUrl + $"review/6b2420bf-61a4-4037-9471-2333429dfcb1", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PutRequest(ReviewAdmin.GenerateJSONForPostReview(), baseUrl + $"review/6b2420bf-61a4-4037-9471-2333429dfcb1", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PutRequest(ReviewAdmin.GenerateJSONForPostReview(), baseUrl + $"reviewes/6b2420bf-61a4-4037-9471-2333429dfcb1", $"Bearer {token.token}", false);
                    break;
            }
        }
    }
}
