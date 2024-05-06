using siclo_plus_api.Helpers;
using siclo_plus_api.Hooks;
using siclo_plus_api.JSON;
using siclo_plus_api.Request;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.UnitTestProvider;
using BearerToken = siclo_plus_api.Models.Token;

namespace siclo_plus_api.Steps
{
    [Binding]
    public class PlanSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        private readonly IUnitTestRuntimeProvider _unitTestRuntimeProvider;
        public static string id;
        Rest rest = new Rest();
        public PlanSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token, IUnitTestRuntimeProvider unitTestRuntimeProvider) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
            _unitTestRuntimeProvider = unitTestRuntimeProvider;
        }
        [Given(@"Send the get request for plan (.*)")]
        [When(@"Send the get request for plan (.*)")]
        public void GivenSendTheGetRequestForPlan(int response)
        {
            _unitTestRuntimeProvider.TestIgnore("03_Get_Plan_401");
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + "plan", $"Bearer {token.token}", "plan");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + "plan", $"Bearer {token.token}", "");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + "plan", $"Bearer 123", "plan");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + "planes", $"Bearer {token.token}", "plan");
                    break;
            }
        }

        [Given(@"Send the get request for plan_id (.*)")]
        [When(@"Send the get request for plan_id (.*)")]
        public void GivenSendTheGetRequestForPlan_Id(int response)
        {
            _unitTestRuntimeProvider.TestIgnore("07_Get_Plan_Id_401");
            switch (response)
            {
                case 200:
                    id = "bd16391b-4e1a-48fa-95c3-e465bf4638f7";
                    rest.GetRequest(baseUrl + $"plan/{id}", $"Bearer {token.token}", "");
                    break;
                case 400:
                    id = "bd16391b-4e1a-48fa-95c3-e465bf4638f7";
                    rest.GetRequest(baseUrl + $"plan/{id}", $"Bearer {token.token}", "403");
                    break;
                case 401:
                    id = "bd16391b-4e1a-48fa-95c3-e465bf4638f7";
                    rest.GetRequest(baseUrl + $"plan/{id}", $"Bearer 123", "");
                    break;
                case 404:
                    id = "bd16391b-4e1a-48fa-95c3-e465bf4638f7";
                    rest.GetRequest(baseUrl + $"planes/{id}", $"Bearer {token.token}", "");
                    break;
            }
        }

        [Given(@"Send the get request for plan_documentation (.*)")]
        public void GivenSendTheGetRequestForPlan_Documentation(int response)
        {
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"plans/documentation", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"plans/documentation", $"Bearer {token.token}", "403");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"plans/documentation", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"planes/{id}", $"Bearer {token.token}", "");
                    break;
            }
        }

    }
}
