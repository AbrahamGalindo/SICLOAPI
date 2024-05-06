using siclo_plus_api.Helpers;
using siclo_plus_api.Hooks;
using siclo_plus_api.Request;
using System;
using siclo_plus_api.JSON;
using TechTalk.SpecFlow;
using BearerToken = siclo_plus_api.Models.Token;

namespace siclo_plus_api.Steps
{
    [Binding]
    public class CategoryAdminSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public static string id;
        Rest rest = new Rest();
        public CategoryAdminSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }
        [Given(@"Send the post request for category admin (.*)")]
        public void GivenSendThePostRequestForCategoryAdmin(int response)
        {
            switch (response)
            {
                case 200:
                    rest.PostRequest(CategoryAdmin.GenerateJSONForPostCategoryAdmin(), baseUrl + $"category", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    break;
                case 400:
                    rest.PostRequest("{}", baseUrl + $"category", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PostRequest(CategoryAdmin.GenerateJSONForPostCategoryAdmin(), baseUrl + $"category", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PostRequest(CategoryAdmin.GenerateJSONForPostCategoryAdmin(), baseUrl + $"categorys", $"Bearer {token.token}", false);
                    break;
            }
        }

        [Given(@"Send the put request for category admin (.*) (.*) (.*)")]
        public void GivenSendThePutRequestForCategoryAdmin(int response, string Name, string Description)
        {            
            switch (response)
            {
                case 200:
                    rest.PostRequest(CategoryAdmin.GenerateJSONForPostCategoryAdmin(), baseUrl + $"category", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest(CategoryAdmin.GenerateJSONForPutCategoryAdmin(Name, Description), baseUrl + $"category/{id}", $"Bearer {token.token}", false);
                    break;
                case 400:
                    id = "123";
                    rest.PutRequest("{}", baseUrl + $"category/{id}", $"Bearer {token.token}", false);
                    break;
                case 401:
                    id = "123";
                    rest.PutRequest("{}", baseUrl + $"category/{id}", $"Bearer 123", false);
                    break;
                case 404:
                    id = "123";
                    rest.PutRequest("{}", baseUrl + $"categorys/{id}", $"Bearer {token.token}", false);
                    break;
            }
        }

        [Given(@"Send the delete request for category admin id (.*)")]
        public void GivenSendTheDeleteRequestForCategoryAdminId(int response)
        {
            switch (response)
            {
                case 204:
                    rest.PostRequest(CategoryAdmin.GenerateJSONForPostCategoryAdmin(), baseUrl + $"category", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.DeleteRequest("", baseUrl + $"category/{id}", $"Bearer {token.token}");
                    break;
                case 400:
                    rest.PostRequest(CategoryAdmin.GenerateJSONForPostCategoryAdmin(), baseUrl + $"category", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.DeleteRequest("{response:123}", baseUrl + $"category/{id}", $"Bearer {token.token}");
                    break;
                case 401:
                    rest.PostRequest(CategoryAdmin.GenerateJSONForPostCategoryAdmin(), baseUrl + $"category", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.DeleteRequest("", baseUrl + $"category/{id}", $"Bearer 123");
                    break;
                case 404:
                    rest.PostRequest(CategoryAdmin.GenerateJSONForPostCategoryAdmin(), baseUrl + $"category", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.DeleteRequest("", baseUrl + $"categorys/{id}", $"Bearer {token.token}");
                    break;
            }
        }

        [Given(@"Send the put request for category admin_picture (.*)")]
        public void GivenSendThePutRequestForCategoryAdmin_Picture(int response)
        {
            switch (response)
            {
                case 200:
                    rest.PostRequest(CategoryAdmin.GenerateJSONForPostCategoryAdmin(), baseUrl + $"category", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"category/{id}/picture", $"Bearer {token.token}", true);
                    break;
                case 400:
                    id = "123";
                    rest.PutRequest("", baseUrl + $"category/{id}/picture", $"Bearer {token.token}", true);
                    break;
                case 401:
                    rest.PostRequest(CategoryAdmin.GenerateJSONForPostCategoryAdmin(), baseUrl + $"category", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"category/{id}/picture", $"Bearer 123", true);
                    break;
                case 404:
                    rest.PostRequest(CategoryAdmin.GenerateJSONForPostCategoryAdmin(), baseUrl + $"category", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"categorys/{id}/picture", $"Bearer {token.token}", true);
                    break;
            }
        }


        [Given(@"Send the delete request for category admin_picture (.*)")]
        public void GivenSendTheDeleteRequestForCategoryAdmin_Picture(int response)
        {
            switch (response)
            {
                case 204:
                    rest.PostRequest(CategoryAdmin.GenerateJSONForPostCategoryAdmin(), baseUrl + $"category", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"category/{id}/picture", $"Bearer {token.token}", true);
                    rest.DeleteRequest("", baseUrl + $"category/{id}/picture", $"Bearer {token.token}");
                    break;
                case 400:
                    rest.PostRequest(CategoryAdmin.GenerateJSONForPostCategoryAdmin(), baseUrl + $"category", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"category/{id}/picture", $"Bearer {token.token}", true);
                    rest.DeleteRequest("{response:200}", baseUrl + $"category/{id}/picture", $"Bearer {token.token}");
                    break;
                case 401:
                    rest.PostRequest(CategoryAdmin.GenerateJSONForPostCategoryAdmin(), baseUrl + $"category", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"category/{id}/picture", $"Bearer {token.token}", true);
                    rest.DeleteRequest("", baseUrl + $"category/{id}/picture", $"Bearer 123");
                    break;
                case 404:
                    rest.PostRequest(CategoryAdmin.GenerateJSONForPostCategoryAdmin(), baseUrl + $"category", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"category/{id}/picture", $"Bearer {token.token}", true);
                    rest.DeleteRequest("", baseUrl + $"categorys/{id}/pictures", $"Bearer {token.token}");
                    break;
            }
        }
    }
}