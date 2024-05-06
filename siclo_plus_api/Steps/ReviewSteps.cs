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
    public class ReviewSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        Rest rest = new Rest();
        public ReviewSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }
        [Given(@"Send the post request for review (.*)")]
        public void GivenSendThePostRequestForReview(int response)
        {
            switch (response)
            {
                case 200:
                    rest.PostRequest(Review.GenerateJSONForPostReview(), baseUrl + $"review/user", $"Bearer {token.token}", false);
                    break;
                case 400:
                    rest.PostRequest("{}", baseUrl + $"review/user", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PostRequest(Review.GenerateJSONForPostReview(), baseUrl + $"review/user", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PostRequest(Review.GenerateJSONForPostReview(), baseUrl + $"reviewes/useres", $"Bearer {token.token}", false);
                    break;
            }
        }
    }
}
