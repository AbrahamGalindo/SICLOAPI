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
    public class PlanAdminSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public static string id;

        public PlanAdminSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;

        }

        [Given(@"Send the post request for plan admin (.*)")]
        public void GivenSendThePostRequestForPlanAdmin(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.PostRequest(PlanAdmin.GenerateJSONForPostPlanAdmin(), baseUrl + $"plan", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    break;
                case 400:
                    rest.PostRequest("{code:123}", baseUrl + $"plan", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PostRequest(PlanAdmin.GenerateJSONForPostPlanAdmin(), baseUrl + $"plan", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PostRequest(PlanAdmin.GenerateJSONForPostPlanAdmin(), baseUrl + $"planess", $"Bearer {token.token}", false);
                    break;
            }
        }

        [Given(@"Send the put request for plan admin (.*)")]
        public void GivenSendThePutRequestForPlanAdmin(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    if (id.Equals("") || id.Equals(null))
                    {
                        rest.PostRequest(PlanAdmin.GenerateJSONForPostPlanAdmin(), baseUrl + $"plan", $"Bearer {token.token}", false);
                        id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    }
                    rest.PutRequest(PlanAdmin.GenerateJSONForPutPlanAdmin(), baseUrl + $"plan/{id}", $"Bearer {token.token}", false);
                    break;
                case 400:
                    if (id.Equals("") || id.Equals(null))
                    {
                        rest.PostRequest(PlanAdmin.GenerateJSONForPostPlanAdmin(), baseUrl + $"plan", $"Bearer {token.token}", false);
                        id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    }
                    rest.PutRequest("{code:123}", baseUrl + $"plan/{id}", $"Bearer {token.token}", false);
                    break;
                case 401:
                    if (id.Equals("") || id.Equals(null))
                    {
                        rest.PostRequest(PlanAdmin.GenerateJSONForPostPlanAdmin(), baseUrl + $"plan", $"Bearer {token.token}", false);
                        id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    }
                    rest.PutRequest(PlanAdmin.GenerateJSONForPutPlanAdmin(), baseUrl + $"plan/{id}", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PutRequest(PlanAdmin.GenerateJSONForPutPlanAdmin(), baseUrl + $"planess/12", $"Bearer {token.token}", false);
                    break;
            }
        }

    }
}
