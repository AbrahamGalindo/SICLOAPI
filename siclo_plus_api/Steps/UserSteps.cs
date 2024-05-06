using siclo_plus_api.Helpers;
using siclo_plus_api.Hooks;
using siclo_plus_api.JSON;
using siclo_plus_api.Request;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.UnitTestProvider;
using BearerToken = siclo_plus_api.Models.Token;

namespace siclo_plus_api.Steps
{
    [Binding]
    public class UserSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        private readonly IUnitTestRuntimeProvider _unitTestRuntimeProvider;
        public static string id;
        Rest rest = new Rest();
        public UserSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token, IUnitTestRuntimeProvider unitTestRuntimeProvider) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
            _unitTestRuntimeProvider = unitTestRuntimeProvider;
        }

        [Given(@"Send the post request for user (.*)")]
        [When(@"Send the post request for user (.*)")]
        public void GivenSendThePostRequestForUser(int response)
        {
            _unitTestRuntimeProvider.TestIgnore("01_Post_user");
            switch (response)
            {
                case 200:
                    rest.PostRequest(User.GenerateJSONForPostUser(), baseUrl + $"user", $"Bearer {token.token}", false);
                    break;
                case 400:
                    rest.PostRequest("", baseUrl + $"user", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PostRequest(User.GenerateJSONForPostUser(), baseUrl + $"user", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PostRequest(User.GenerateJSONForPostUser(), baseUrl + $"useesr", $"Bearer {token.token}", false);
                    break;
            }
        }

        [Given(@"Send the get request for user (.*)")]
        public void GivenSendTheGetRequestForUser(int response)
        {
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"user/me", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"user/me", $"Bearer {token.token}", "403");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"user/me", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"useres/me", $"Bearer {token.token}", "");
                    break;
            }
        }

        [Given(@"Send the put request for user (.*)")]
        public void GivenSendThePutRequestForUser(int response)
        {
            switch (response)
            {
                case 200:
                    rest.PutRequest(User.GenerateJSONForPutUser(), baseUrl + $"user/me", $"Bearer {token.token}", false);
                    break;
                case 400:
                    rest.PutRequest("", baseUrl + $"user/me", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PutRequest(User.GenerateJSONForPutUser(), baseUrl + $"user/me", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PutRequest(User.GenerateJSONForPutUser(), baseUrl + $"useres/me", $"Bearer {token.token}", false);
                    break;
            }
        }

        [Given(@"Send the put request for user_picture (.*)")]
        public void GivenSendThePutRequestForUser_Picture(int response)
        {
            switch (response)
            {
                case 200:
                    rest.PutRequest("{}", baseUrl + $"user/me/picture", $"Bearer {token.token}", true);
                    break;
                case 400:
                    rest.PutRequest("", baseUrl + $"user/me/picture", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PutRequest("{}", baseUrl + $"user/me/picture", $"Bearer 123", true);
                    break;
                case 404:
                    rest.PutRequest("{}", baseUrl + $"user/meas/pictureas", $"Bearer {token.token}", true);
                    break;
            }
        }

        [Given(@"Send the get request for user_subscription (.*)")]
        public void GivenSendTheGetRequestForUser_Subscription(int response)
        {
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"user/me/subscription", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"user/me/subscription", $"Bearer {token.token}", "403");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"user/me/subscription", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"user/mes/subscriptions", $"Bearer {token.token}", "");
                    break;
            }
        }

        [Given(@"Send the post request for user_subscription (.*)")]
        public void GivenSendThePostRequestForUser_Subscription(int response)
        {
            switch (response)
            {
                case 200:
                    rest.PostRequest(User.GenerateJSONForPostUserSubscription(), baseUrl + $"user/me/subscription", $"Bearer {token.token}", false);
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"user/me/subscription", $"Bearer {token.token}", "403");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"user/me/subscription", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"user/mes/subscriptions", $"Bearer {token.token}", "");
                    break;
            }
        }

    }
}
