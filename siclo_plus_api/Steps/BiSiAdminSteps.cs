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
    public class BiSiAdminSteps : Base

    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        private readonly IUnitTestRuntimeProvider _unitTestRuntimeProvider;
        public BiSiAdminSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token, IUnitTestRuntimeProvider unitTestRuntimeProvider) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
            _unitTestRuntimeProvider = unitTestRuntimeProvider;
        }
        Rest rest = new Rest();
        [Given(@"Send the get request for bisi_admin (.*) (.*)")]
        [When(@"Send the get request for bisi_admin (.*) (.*)")]
        public void GivenSendTheGetRequestForBisiAdmin(string Email, int response)
        {
            _unitTestRuntimeProvider.TestIgnore("01_Get_bisi_admin");
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"bisi?page=1&limit=20&email={Email}", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"bisi?page=1&limit=20&emaii={Email}", $"Bearer {token.token}", "");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"bisi?page=1&limit=20&email={Email}", "Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"bisi1?page=1&limit=20&email={Email}", $"Bearer {token.token}", "");
                    break;
            }
        }

        [Given(@"Send the post request for bisi_admin (.*) (.*)")]
        [When(@"Send the post request for bisi_admin (.*) (.*)")]
        public void GivenSendThePostRequestForBisi_Admin(string Email, int response)
        {
            _unitTestRuntimeProvider.TestIgnore("02_Post_bisi_admin");
            rest.PostRequest(BiSiAdmin.GenerateJSONForPostBisiAdmin(Email), baseUrl + $"bisi", $"Bearer {token.token}", false);

            switch (response)
            {
                case 400:
                    rest.PostRequest(BiSiAdmin.GenerateJSONForPostBisiAdmin(Email) + "$%&/%$%&%&57", baseUrl + $"bisi", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PostRequest(BiSiAdmin.GenerateJSONForPostBisiAdmin(Email), baseUrl + $"bisi", $"Bearer {token.token}123456", false);
                    break;
                case 404:
                    rest.PostRequest(BiSiAdmin.GenerateJSONForPostBisiAdmin(Email), baseUrl + $"bisi@#$!", $"Bearer {token.token}", false);
                    break;
                case 405:
                    rest.DeleteRequest(BiSiAdmin.GenerateJSONForPostBisiAdmin(Email), baseUrl + $"bisi", $"Bearer {token.token}");
                    break;
            }
        }
        [Given(@"Send the put request for bisi_admin (.*)")]
        [When(@"Send the put request for bisi_admin (.*)")]
        public void GivenSendThePutRequestForBisi_Admin(string Email)
        {
            _unitTestRuntimeProvider.TestIgnore("03_Put_bisi_admin");
            string id = "d73fbc79-9fd5-401f-81ce-3884971cfa5d";
            rest.PutRequest(BiSiAdmin.GenerateJSONForPutBisiAdmin(Email), baseUrl + $"bisi?id={id}", $"Bearer {token.token}", false);
        }


        [Given(@"Send the delete request for bisi_admin (.*)")]
        [When(@"Send the delete request for bisi_admin (.*)")]
        public void GivenSendTheDeleteRequestForBisi_Admin(int response)
        {
            _unitTestRuntimeProvider.TestIgnore("04_Delete_bisi_admin");
            switch (response)
            {
                case 200:
                    rest.DeleteRequest("", baseUrl + $"bisi/d73fbc79-9fd5-401f-81ce-3884971cfa5d", $"Bearer {token.token}");
                    break;
                case 400:
                    rest.DeleteRequest("{bisi:1234}", baseUrl + $"user/bisi_admin", $"Bearer {token.token}");
                    break;
            }
        }
    }
}
