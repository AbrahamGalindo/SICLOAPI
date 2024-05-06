using siclo_plus_api.Helpers;
using siclo_plus_api.Hooks;
using siclo_plus_api.Request;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.UnitTestProvider;
using siclo_plus_api.JSON;
using BearerToken = siclo_plus_api.Models.Token;

namespace siclo_plus_api.Steps
{
    [Binding]
    public class BrightcoveSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        private readonly IUnitTestRuntimeProvider _unitTestRuntimeProvider;
        public BrightcoveSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token, IUnitTestRuntimeProvider unitTestRuntimeProvider) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
            _unitTestRuntimeProvider = unitTestRuntimeProvider;
        }

        [Given(@"Send the post request for brightcove videos (.*)")]
        [When(@"Send the post request for brightcove videos (.*)")]
        public void GivenSendThePostRequestForBrightcoveVideos(int response)
        {
            _unitTestRuntimeProvider.TestIgnore("01_Post_brightcove_videos");
            Rest rest = new Rest();            
            switch (response)
            {
                case 200:
                    rest.PostRequest(Brightcove.GenerateJSONForPostVideos(), baseUrl + $"birightcove/webhook/videos", $"Bearer {token.token}", false);
                    break;
                case 400:
                    rest.PostRequest("", baseUrl + $"birightcove/webhook/videos", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PostRequest(Brightcove.GenerateJSONForPostVideos(), baseUrl + $"birightcove/webhook/videos", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PostRequest(Brightcove.GenerateJSONForPostVideos(), baseUrl + $"birightcove/webhook/videosss", $"Bearer {token.token}", false);
                    break;
            }
        }

    }
}
