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
    public class TutorialAdminSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public static string id;

        Rest rest = new Rest();
        public TutorialAdminSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }
        [Given(@"Send the post request for tutorial (.*)")]
        public void GivenSendThePostRequestForTutorial(int response)
        {
            switch (response)
            {
                case 200:
                    rest.PostRequest(TutorialAdmin.GenerateJSONForPostTutorial(), baseUrl + $"tutorial", $"Bearer {token.token}", false);
                    break;
                case 400:
                    rest.PostRequest("{tutorial:string}", baseUrl + $"tutorial", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PostRequest(TutorialAdmin.GenerateJSONForPostTutorial(), baseUrl + $"tutorial", $"Bearer 123", true);
                    break;
                case 404:
                    rest.PostRequest(TutorialAdmin.GenerateJSONForPostTutorial(), baseUrl + $"tutoriales", $"Bearer {token.token}", true);
                    break;
            }
        }
    }
}
