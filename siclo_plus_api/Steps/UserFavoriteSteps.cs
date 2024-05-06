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
    public class UserFavoriteSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public static string id;
        public UserFavoriteSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }
        [Given(@"Send the post request for user_favorite (.*)")]
        public void GivenSendThePostRequestForUser_Favorite(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.PostRequest(UserFavorite.GenerateJSONForPostUserFavorite(), baseUrl + $"user/favorite", $"Bearer {token.token}", false);
                    break;
                case 400:
                    rest.PostRequest("{some:some}", baseUrl + $"user/favorite", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PostRequest(UserFavorite.GenerateJSONForPostUserFavorite(), baseUrl + $"user/favorite", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PostRequest(UserFavorite.GenerateJSONForPostUserFavorite(), baseUrl + $"useres/favorite", $"Bearer {token.token}", false);
                    break;
            }
        }

        [Given(@"Send the get request for user_favorite (.*)")]
        public void GivenSendTheGetRequestForUser_Favorite(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"user/favorites", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"user/favorite", $"Bearer {token.token}", "");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"user/favorites", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"useres/favorites", $"Bearer {token.token}", "");
                    break;
            }
        }
        [Given(@"Send the delete request for user_favorite (.*)")]
        public void GivenSendTheDeleteRequestForUser_Favorite(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.DeleteRequest(UserFavorite.GenerateJSONForPostUserFavorite(), baseUrl + $"user/favorite", $"Bearer {token.token}");
                    break;
                case 400:
                    rest.DeleteRequest("{some:some}", baseUrl + $"user/favorite", $"Bearer {token.token}");
                    break;
                case 401:
                    rest.DeleteRequest(UserFavorite.GenerateJSONForPostUserFavorite(), baseUrl + $"user/favorite", $"Bearer 123");
                    break;
                case 404:
                    rest.DeleteRequest(UserFavorite.GenerateJSONForPostUserFavorite(), baseUrl + $"useres/favorite", $"Bearer {token.token}");
                    break;
            }
        }

    }
}
