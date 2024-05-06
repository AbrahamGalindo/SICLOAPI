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
    public class PlayListSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public static string id;
        Rest rest = new Rest();
        public PlayListSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }
        [Given(@"Send the get request for play list (.*)")]
        public void GivenSendTheGetRequestForPlayList(int response)
        {
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"playlist", $"Bearer {token.token}", "");
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "[");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"playlist", $"Bearer {token.token}", "");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"playlist", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"playlistes", $"Bearer {token.token}", "");
                    break;
            }
        }
        [Given(@"Send the get request for play list_id (.*)")]
        public void GivenSendTheGetRequestForPlayList_Id(int response)
        {
            switch (response)
            {
                case 200:
                    if (id.Equals("") || id.Equals(null))
                    {
                        rest.GetRequest(baseUrl + $"playlist", $"Bearer {token.token}", "");
                        id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    }
                    rest.GetRequest(baseUrl + $"playlist/{id}", $"Bearer {token.token}", "");
                    break;
                case 400:
                    if (id.Equals("") || id.Equals(null))
                    {
                        rest.GetRequest(baseUrl + $"playlist", $"Bearer {token.token}", "");
                        id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    }
                    rest.GetRequest(baseUrl + $"playlist/{id}", $"Bearer {token.token}", "");
                    break;
                case 401:
                    if (id.Equals("") || id.Equals(null))
                    {
                        rest.GetRequest(baseUrl + $"playlist", $"Bearer {token.token}", "");
                        id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    }
                    rest.GetRequest(baseUrl + $"playlist/{id}", $"Bearer 123", "");
                    break;
                case 404:
                    if (id.Equals("") || id.Equals(null))
                    {
                        rest.GetRequest(baseUrl + $"playlist", $"Bearer {token.token}", "");
                        id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    }
                    rest.GetRequest(baseUrl + $"playlistes/{id}", $"Bearer {token.token}", "");
                    break;
            }
        }

    }
}
