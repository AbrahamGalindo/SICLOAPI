using siclo_plus_api.Helpers;
using siclo_plus_api.Hooks;
using siclo_plus_api.JSON;
using siclo_plus_api.Request;
using TechTalk.SpecFlow;
using BearerToken = siclo_plus_api.Models.Token;

namespace siclo_plus_api.Steps
{
    [Binding]
    public class BrandSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        Rest rest = new Rest();
        public BrandSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }

        [Given(@"Send the get request for brand (.*)")]
        public void GivenSendTheGetRequestForBrand(int response)
        {            
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"brand", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"brand/12", $"Bearer {token.token}", "");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"brand", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"brandes", $"Bearer {token.token}", "");
                    break;
            }
        }

        [Given(@"Send the get request for brand_id (.*) (.*)")]
        public void GivenSendTheGetRequestForBrand_Id(string Id, int response)
        {
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"brand/{Id}", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"brand/{Id}", $"Bearer {token.token}", "");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"brand/{Id}", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"brandes/{Id}", $"Bearer {token.token}", "");
                    break;
            }
        }
    }
}
