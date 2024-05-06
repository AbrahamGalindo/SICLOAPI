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
    public class UserProfileSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public static string id;
        public UserProfileSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }
        [Given(@"Send the get request for users_profile (.*)")]
        public void GivenSendTheGetRequestForUsers_Profile(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"user/profile", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"user/profile", $"Bearer {token.token}", "plan");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"user/profile", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"useesr/profile", $"Bearer {token.token}", "");
                    break;
            }
        }

        [Given(@"Send the post request for users_profile (.*)")]
        public void GivenSendThePostRequestForUsers_Profile(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.PostRequest(UserProfile.GenerateJSONForPostProfile(), baseUrl + $"user/profile", $"Bearer {token.token}", false);
                    break;
                case 400:
                    rest.PostRequest("{123}", baseUrl + $"user/profile", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PostRequest(UserProfile.GenerateJSONForPostProfile(), baseUrl + $"user/profile", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PostRequest(UserProfile.GenerateJSONForPostProfile(), baseUrl + $"userer/profile", $"Bearer {token.token}", false);
                    break;
            }
        }
        [Given(@"Send the get request for users_profile_id (.*)")]
        public void GivenSendTheGetRequestForUsers_Profile_Id(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"user/profile", $"Bearer {token.token}", "");
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "]");
                    rest.GetRequest(baseUrl + $"user/profile/{id}", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"user/profile/{id}", $"Bearer {token.token}", "plan");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"user/profile/{id}", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"useesr/profile/{id}", $"Bearer {token.token}", "");
                    break;
            }
        }
        [Given(@"Send the delete request for users_profile_id (.*)")]
        public void GivenSendTheDeleteRequestForUsers_Profile_Id(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"user/profile", $"Bearer {token.token}", "");
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "]");
                    rest.DeleteRequest("", baseUrl + $"user/profile/{id}", $"Bearer {token.token}");
                    break;
                case 400:
                    rest.DeleteRequest("{delete+delete}", baseUrl + $"user/profile/{id}", $"Bearer {token.token}");
                    break;
                case 401:
                    rest.DeleteRequest("", baseUrl + $"user/profile/{id}", $"Bearer 123");
                    break;
                case 404:
                    rest.DeleteRequest("", baseUrl + $"useerr/profile/{id}", $"Bearer {token.token}");
                    break;
            }
        }

    }
}
