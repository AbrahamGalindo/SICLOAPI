using siclo_plus_api.Helpers;
using siclo_plus_api.Hooks;
using siclo_plus_api.Request;
using System;
using TechTalk.SpecFlow;
using BearerToken = siclo_plus_api.Models.Token;

namespace siclo_plus_api.Steps
{
    [Binding]
    public class InstructorSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public static string id;
        Rest rest = new Rest();
        public InstructorSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }
        [Given(@"Send the get request for instructor (.*)")]
        public void GivenSendTheGetRequestForInstructor(int response)
        {            
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + "instructor", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + "instructor", $"Bearer {token.token}", "403");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + "instructor", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + "instructorsa", $"Bearer {token.token}", "");
                    break;
            }
        }

        [Given(@"Send the get request for instructor_id (.*)")]
        public void GivenSendTheGetRequestForInstructor_Id(int response)
        {
            switch (response)
            {
                case 200:
                    id = "32e23a19-a5ce-473c-93fb-67f4efd4fdb7";
                    rest.GetRequest(baseUrl + $"instructor/{id}", $"Bearer {token.token}", "");
                    break;
                case 400:
                    id = "32e23a19-a5ce-473c-93fb-67f4efd4fdb7";
                    rest.GetRequest(baseUrl + $"instructor/{id}", $"Bearer {token.token}", "plan");
                    break;
                case 401:
                    id = "32e23a19-a5ce-473c-93fb-67f4efd4fdb7";
                    rest.GetRequest(baseUrl + $"instructor/{id}", $"Bearer 123", "");
                    break;
                case 404:
                    id = "32e23a19-a5ce-473c-93fb-67f4efd4fdb7";
                    rest.GetRequest(baseUrl + $"instructoresss/{id}", $"Bearer {token.token}", "");
                    break;
            }
        }
    }
}
