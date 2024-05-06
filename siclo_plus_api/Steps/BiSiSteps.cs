using siclo_plus_api.Helpers;
using siclo_plus_api.Hooks;
using siclo_plus_api.JSON;
using siclo_plus_api.Request;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.UnitTestProvider;
using BearerToken = siclo_plus_api.Models.Token;

namespace siclo_plus_api.Steps
{
    [Binding]
    public class BiSiSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        private readonly IUnitTestRuntimeProvider _unitTestRuntimeProvider;
        public BiSiSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token, IUnitTestRuntimeProvider unitTestRuntimeProvider) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
            _unitTestRuntimeProvider = unitTestRuntimeProvider;
        }

        Rest rest = new Rest();
        [Given(@"Send the post request for bisi (.*)")]
        public void GivenSendThePostRequestForBisi(int response)
        {
            switch (response)
            {
                case 201:
                    rest.PostRequest(BiSi.GenerateJSONForPostBisi(), baseUrl + $"user/bisi", $"Bearer {token.token}", false);
                    break;
                case 400:
                    rest.PostRequest(BiSi.GenerateJSONForPostBisi() + "!$%&&&$%&4", baseUrl + $"user/bisi", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PostRequest(BiSi.GenerateJSONForPostBisi(), baseUrl + $"user/bisi", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PostRequest(BiSi.GenerateJSONForPostBisi(), baseUrl + $"users1/bisi", $"Bearer {token.token}", false);
                    break;
            }
            
        }

        [Given(@"Send the put request for bisi (.*)")]
        [When(@"Send the put request for bisi (.*)")]
        public void GivenSendThePutRequestForBisi(int response)
        {
            _unitTestRuntimeProvider.TestIgnore("02_Put_bisi");
            rest.PutRequest(BiSi.GenerateJSONForPutBisi(), baseUrl + $"user/bisi", $"Bearer {token.token}",false);
            switch (response)
            {
                case 200:
                    rest.PutRequest(BiSi.GenerateJSONForPutBisi(), baseUrl + $"user/bisi", $"Bearer {token.token}", false);
                    break;
                case 400:
                    rest.PutRequest(BiSi.GenerateJSONForPutBisi() + "!$%&&&$%&4", baseUrl + $"user/bisi", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PutRequest(BiSi.GenerateJSONForPutBisi(), baseUrl + $"user/bisi", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PutRequest(BiSi.GenerateJSONForPutBisi(), baseUrl + $"users1/bisi", $"Bearer {token.token}", false);
                    break;
            }
        }
     
        [Given(@"Send the delete request for bisi (.*)")]
        public void GivenSendTheDeleteRequestForBisi(int response)
        {
            switch (response)
            {
                case 200:
                    rest.DeleteRequest("", baseUrl + $"user/bisi", $"Bearer {token.token}");
                    break;
                case 400:
                    rest.DeleteRequest("{bisi:1234}", baseUrl + $"user/bisi", $"Bearer {token.token}");
                    break;
                case 401:
                    rest.DeleteRequest("", baseUrl + $"user/bisi", $"Bearer 123");
                    break;
                case 404:
                    rest.DeleteRequest("", baseUrl + $"user12/bisi", $"Bearer {token.token}");
                    break;
            }
        }
       

    }
}
