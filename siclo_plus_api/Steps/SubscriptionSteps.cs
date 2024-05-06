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
    public class SubscriptionSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public static string id;
        public static string subscriptionId;
        public SubscriptionSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }
        [Given(@"Send the post request for subscription (.*)")]
        public void GivenSendThePostRequestForSubscription(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.PostRequest(Subscription.GenerateJSONForPostSubscription(), baseUrl + $"subscription", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    subscriptionId = Helper.GetItemFromResponse("externalId", Rest.response.Content.ToString(), "");
                    break;
                case 400:
                    rest.PostRequest("{}", baseUrl + $"subscription", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PostRequest(Subscription.GenerateJSONForPostSubscription(), baseUrl + $"subscription", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PostRequest(Subscription.GenerateJSONForPostSubscription(), baseUrl + $"subscriptiones", $"Bearer {token.token}", false);
                    break;
            }
        }

        [Given(@"Send the put request for subscription (.*)")]
        public void GivenSendThePutRequestForSubscription(int response)
        {
            id = "c846b4e6-b26c-4193-9602-2bd66f54810e";
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.PutRequest(Subscription.GenerateJSONForPutSubscription(), baseUrl + $"subscription/{id}/update-payment", $"Bearer {token.token}", false);
                    break;
                case 400:
                    rest.PutRequest("{}", baseUrl + $"subscription/{id}/update-payment", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PutRequest(Subscription.GenerateJSONForPutSubscription(), baseUrl + $"subscription/{id}/update-payment", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PutRequest(Subscription.GenerateJSONForPutSubscription(), baseUrl + $"subscriptiones/{id}/update-payment", $"Bearer {token.token}", false);
                    break;
            }
        }

        [Given(@"Send the delete request for subscription (.*)")]
        public void GivenSendTheDeleteRequestForSubscription(int response)
        {
            subscriptionId = "c846b4e6-b26c-4193-9602-2bd66f54810e";
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.DeleteRequest(Subscription.GenerateJSONForDeleteSubscription(subscriptionId), baseUrl + $"subscription/cancel", $"Bearer {token.token}");
                    break;
                case 400:
                    rest.PutRequest("{}", baseUrl + $"subscription/{id}/update-payment", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PutRequest(Subscription.GenerateJSONForPutSubscription(), baseUrl + $"subscription/{id}/update-payment", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PutRequest(Subscription.GenerateJSONForPutSubscription(), baseUrl + $"subscriptiones/{id}/update-payment", $"Bearer {token.token}", false);
                    break;
            }
        }


    }
}
