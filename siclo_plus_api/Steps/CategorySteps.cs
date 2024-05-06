using siclo_plus_api.Helpers;
using siclo_plus_api.Hooks;
using siclo_plus_api.Request;
using System;
using TechTalk.SpecFlow;
using BearerToken = siclo_plus_api.Models.Token;

namespace siclo_plus_api.Steps
{
    [Binding]
    public class CategorySteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public static string id;
        public CategorySteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }
        Rest rest = new Rest();
        [Given(@"Send the get request for category (.*)")]
        public void GivenSendTheGetRequestForCategory(int response)
        {
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + "category", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + "category", $"Bearer {token.token}", "plan");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + "category", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + "categorys", $"Bearer {token.token}", "");
                    break;
            }
        }

        [Given(@"Send the get request for category_id (.*)")]
        public void GivenSendTheGetRequestForCategory_Id(int response)
        {
            switch (response)
            {
                case 200:
                    id = "15639a60-6cd8-4ce1-b94e-f871ba72abb0";
                    rest.GetRequest(baseUrl + $"category/{id}", $"Bearer {token.token}", "");
                    break;
                case 400:
                    id = "15639a60-6cd8-4ce1-b94e-f871ba72abb0";
                    rest.GetRequest(baseUrl + $"category/{id}", $"Bearer {token.token}", "plan");
                    break;
                case 401:
                    id = "15639a60-6cd8-4ce1-b94e-f871ba72abb0";
                    rest.GetRequest(baseUrl + $"category/{id}", $"Bearer 123", "");
                    break;
                case 404:
                    id = "15639a60-6cd8-4ce1-b94e-f871ba72abb0";
                    rest.GetRequest(baseUrl + $"categorys/{id}", $"Bearer {token.token}", "");
                    break;
            }
        }

        [Given(@"Send the get request for category_id_product (.*)")]
        public void GivenSendTheGetRequestForCategory_Id_Product(int response)
        {
            switch (response)
            {
                case 200:
                    id = "15639a60-6cd8-4ce1-b94e-f871ba72abb0";
                    rest.GetRequest(baseUrl + $"category/{id}/product", $"Bearer {token.token}", "");
                    break;
                case 400:
                    id = "15639a60-6cd8-4ce1-b94e-f871ba72abb0";
                    rest.GetRequest(baseUrl + $"category/{id}/product", $"Bearer {token.token}", "plan");
                    break;
                case 401:
                    id = "15639a60-6cd8-4ce1-b94e-f871ba72abb0";
                    rest.GetRequest(baseUrl + $"category/{id}/product", $"Bearer 123", "");
                    break;
                case 404:
                    id = "15639a60-6cd8-4ce1-b94e-f871ba72abb0";
                    rest.GetRequest(baseUrl + $"categorys/{id}/product", $"Bearer {token.token}", "");
                    break;
            }
        }
    }
}
