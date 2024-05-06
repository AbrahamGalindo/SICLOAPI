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
    public class UserAdminSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public static string id;
        public UserAdminSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }

        [Given(@"Send the get request for users (.*)")]
        public void GivenSendTheGetRequestForUsers(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"user", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"user", $"Bearer {token.token}", "plan");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"user", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"useres", $"Bearer {token.token}", "");
                    break;
            }
        }

        [Given(@"Send the get request for users_id (.*)")]
        public void GivenSendTheGetRequestForUsers_Id(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.GetRequest(baseUrl + $"user/f349fab7-1c09-4071-a64e-355fbee609e5", $"Bearer {token.token}", "");
                    break;
                case 400:
                    rest.GetRequest(baseUrl + $"user/4fef0737-d581-4a80-b50a-e5645436aec0", $"Bearer {token.token}", "plan");
                    break;
                case 401:
                    rest.GetRequest(baseUrl + $"user/4fef0737-d581-4a80-b50a-e5645436aec0", $"Bearer 123", "");
                    break;
                case 404:
                    rest.GetRequest(baseUrl + $"useres/4fef0737-d581-4a80-b50a-e5645436aec0", $"Bearer {token.token}", "");
                    break;
            }
        }

        [Given(@"Send the delete request for users_id (.*)")]
        public void GivenSendTheDeleteRequestForUsers_Id(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    //Crear user a eliminar
                    rest.DeleteRequest("", baseUrl + $"user/f349fab7-1c09-4071-a64e-355fbee609e5", $"Bearer {token.token}");
                    break;
                case 400:
                    rest.DeleteRequest("{delete=:qwe}", baseUrl + $"user/819d7866-4668-4578-9270-83d58ea39911", $"Bearer {token.token}");
                    break;
                case 401:
                    rest.DeleteRequest("", baseUrl + $"user/819d7866-4668-4578-9270-83d58ea39911", $"Bearer 123");
                    break;
                case 404:
                    rest.DeleteRequest("", baseUrl + $"useresw/819d7866-4668-4578-9270-83d58ea39911", $"Bearer {token.token}");
                    break;
            }
        }
    }
}
