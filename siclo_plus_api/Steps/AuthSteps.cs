using NUnit.Framework;
using siclo_plus_api.Helpers;
using siclo_plus_api.Hooks;
using siclo_plus_api.JSON;
using siclo_plus_api.Request;
using BearerToken = siclo_plus_api.Models.Token;
using TechTalk.SpecFlow;
using System;

namespace siclo_plus_api.Steps
{
    [Binding]
    public class AuthSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public AuthSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }

        Rest rest = new Rest();
        [Given(@"Send the post request for forgot password (.*) (.*)")]
        public void GivenSendThePostRequestForForgotPassword(string Email, int response)
        {            
            switch (response)
            {
                case 204:
                    rest.PostRequest(Auth.GenerateJSONForPostForgotPassword(Email), baseUrl + $"auth/forgot-password", "", false);
                    break;
                case 400:
                    rest.PostRequest(Auth.GenerateJSONForPostForgotPasswordBadRequest(Email), baseUrl + $"auth/forgot-password", "", false);
                    break;
                case 405:
                    rest.DeleteRequest(Auth.GenerateJSONForPostForgotPasswordBadRequest(Email), baseUrl + $"auth/forgot-password", "");
                    break;

            }

        }

        [Given(@"Send the post request for login (.*) (.*) (.*)")]
        public void GivenSendThePostRequestForLogin(string Email, int response, string password)
        {
            switch (response)
            {
                case 200:
                    rest.PostRequest(Auth.GenerateJSONForPostLogin(Email, password), baseUrl + $"auth/login", "", false);
                    break;

            }

        }

        [Given(@"Send the get request for documentation (.*) (.*) (.*)")]
        public void GivenSendTheGetRequestForDocumentation(string Email,int response, string password)
        {
            switch (response)
            {
                case 405:
                    rest.PostRequest(Auth.GenerateJSONForPostLogin(Email, password), baseUrl + $"auth/documentation", "", false);
                    break;
            }
        }


        [Then(@"The response should match with the expected results (.*)")]
        public void ThenTheResponseShouldMatchWithTheExpectedResults(string response)
        {
            spectedResponse = response.ToString();
            Assert.IsTrue(rest.HasCorrectResponse(Int32.Parse(response)));
        }
    }
}
