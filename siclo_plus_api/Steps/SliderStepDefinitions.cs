using siclo_plus_api.Helpers;
using siclo_plus_api.Hooks;
using siclo_plus_api.JSON;
using siclo_plus_api.Request;
using System;
using siclo_plus_api.Steps;
using TechTalk.SpecFlow;
using BearerToken = siclo_plus_api.Models.Token;

namespace siclo_plus_api
{
    [Binding]
    public class SliderStepDefinitions : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public static string id;
        Rest rest = new Rest();
        public SliderStepDefinitions(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }
    
        [Given(@"Send the get request for slider (.*)")]
        public void GivenSendTheGetRequestForSlider(int response)
        {
            switch (response)
            {
                
                case 200:
                    rest.GetRequest(baseUrl + $"slider", $"Bearer {token.token}", "slider");
                    break;
                case 403:
                    rest.GetRequest(baseUrl + $"slider", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"/slider123", $"Bearer {token.token}", "");
                    break;
            }
        }
        [Given(@"Send the get request for slider_id (.*)")]
        public void GivenSendTheGetRequestForSlider_Id(int response)
        {
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"slider/b634c28e-4b9a-40f3-8060-bdc26d779093", $"Bearer {token.token}", "");
                    break;
                case 403:
                    rest.GetRequest(baseUrl + $"slider/b634c28e-4b9a-40f3-8060-bdc26d779093", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"/slider/b634c28e-4b9a-", $"Bearer {token.token}", "");
                    break;
            }
        }

        [Given(@"Send the get request for slider_documentation (.*)")]
        public void GivenSendTheGetRequestForSlider_Documentation(int response)
        {
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"slider/documentation", $"Bearer {token.token}", "");
                    break;
                case 403:
                    rest.GetRequest(baseUrl + $"slider/documentation", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"/slideres/documentation", $"Bearer {token.token}", "");
                    break;
            }
        }

    }
}
