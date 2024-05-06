using siclo_plus_api.Helpers;
using siclo_plus_api.Hooks;
using siclo_plus_api.JSON;
using siclo_plus_api.Request;
using TechTalk.SpecFlow;
using BearerToken = siclo_plus_api.Models.Token;

namespace siclo_plus_api.Steps
{
    [Binding]
    public class BrandAdminSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public static string id;
        Rest rest = new Rest();
        public BrandAdminSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }


        [Given(@"Send the post request for brand admin (.*) (.*) (.*) (.*)")]
        public void GivenSendThePostRequestForBrandAdminid(string name, string description, string color, int response)
        {           
            switch (response)
            {
                case 200:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    break;
                case 400:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdminBadRequest(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdminBadRequest(name, description, color), baseUrl + $"brand", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdminBadRequest(name, description, color), baseUrl + $"brandi", $"Bearer {token.token}", false);
                    break;
            }
        }

        [Then(@"Delete this brand")]
        public void ThenDeleteThisBrand()
        {
            rest.DeleteRequest("", baseUrl + $"brand/{id}", $"Bearer {token.token}");
        }

        [Given(@"Send the put request for brand admin_id (.*) (.*) (.*) (.*)")]
        public void GivenSendThePutRequestForBrandAdminId(string name, string description, string color, int response)
        {
            switch (response)
            {
                case 204:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest(BrandAdmin.GenerateJSONForPutBrandAdmin(name, description, color), baseUrl + $"brand/{id}", $"Bearer {token.token}", false);
                    break;
                case 400:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest(BrandAdmin.GenerateJSONForPutBrandAdminBadRequest(name, description, color), baseUrl + $"brand/{id}", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest(BrandAdmin.GenerateJSONForPutBrandAdmin(name, description, color), baseUrl + $"brand/{id}", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest(BrandAdmin.GenerateJSONForPutBrandAdmin(name, description, color), baseUrl + $"brandy/{id}", $"Bearer 123", false);
                    break;
            }
        }

        [Given(@"Send the delete request for brand admin_id (.*) (.*) (.*) (.*)")]
        public void GivenSendTheDeleteRequestForBrandAdminId(string name, string description, string color, int response)
        {
            switch (response)
            {
                case 200:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.DeleteRequest("", baseUrl + $"brand/{id}", $"Bearer {token.token}");
                    break;
                case 400:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.DeleteRequest("{delete:1235}", baseUrl + $"brand/{id}", $"Bearer {token.token}");
                    break;
                case 401:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.DeleteRequest("", baseUrl + $"brand/{id}", $"Bearer 123");
                    break;
                case 404:
                    rest.DeleteRequest("", baseUrl + $"brand", $"Bearer {token.token}");
                    break;
            }
        }

        [Given(@"Send the put request for brand admin cover (.*) (.*) (.*) (.*)")]
        public void GivenSendThePutRequestForBrandAdminCover(string name, string description, string color, int response)
        {
            switch (response)
            {
                case 200:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"brand/{id}/cover", $"Bearer {token.token}", true);
                    break;
                case 400:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("{body:false}", baseUrl + $"brand/{id}/cover", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"brand/{id}/cover", $"Bearer 123", true);
                    break;
                case 404:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"brand/{id}/coverage", $"Bearer {token.token}", true);
                    break;
            }
        }

        [Given(@"Send the delete request for brand admin cover (.*) (.*) (.*) (.*)")]
        public void GivenSendTheDeleteRequestForBrandAdminCover(string name, string description, string color, int response)
        {
            switch (response)
            {
                case 200:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"brand/{id}/cover", $"Bearer {token.token}", true);
                    rest.DeleteRequest("", baseUrl + $"brand/{id}/cover", $"Bearer {token.token}");
                    break;
                case 400:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"brand/{id}/cover", $"Bearer {token.token}", true);
                    rest.DeleteRequest("{some:123}", baseUrl + $"brand/{id}/cover", $"Bearer {token.token}");
                    break;
                case 401:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"brand/{id}/cover", $"Bearer {token.token}", true);
                    rest.DeleteRequest("", baseUrl + $"brand/{id}/cover", $"Bearer 123");
                    break;
                case 404:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"brand/{id}/cover", $"Bearer {token.token}", true);
                    rest.DeleteRequest("", baseUrl + $"brand/{id}/coverage", $"Bearer {token.token}");
                    break;
            }
        }


        [Given(@"Send the put request for brand admin picture (.*) (.*) (.*) (.*)")]
        public void GivenSendThePutRequestForBrandAdminPicture(string name, string description, string color, int response)
        {
            switch (response)
            {
                case 200:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"brand/{id}/picture", $"Bearer {token.token}", true);
                    break;
                case 400:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("", baseUrl + $"brand/{id}/picture", $"Bearer {token.token}", true);
                    break;
                case 401:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"brand/{id}/picture", $"Bearer 123", true);
                    break;
                case 404:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"brand/{id}/pictures", $"Bearer {token.token}", true);
                    break;
            }
        }

        [Given(@"Send the delete request for brand admin picture (.*) (.*) (.*) (.*)")]
        public void GivenSendTheDeleteRequestForBrandAdminPicture(string name, string description, string color, int response)
        {
            switch (response)
            {
                case 200:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"brand/{id}/picture", $"Bearer {token.token}", true);
                    rest.DeleteRequest("", baseUrl + $"brand/{id}/picture", $"Bearer {token.token}");
                    break;
                case 400:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"brand/{id}/picture", $"Bearer {token.token}", true);
                    rest.DeleteRequest("{adad:asdqw}", baseUrl + $"brand/{id}/picture", $"Bearer {token.token}");
                    break;
                case 401:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"brand/{id}/picture", $"Bearer {token.token}", true);
                    rest.DeleteRequest("", baseUrl + $"brand/{id}/picture", $"Bearer 123");
                    break;
                case 404:
                    rest.PostRequest(BrandAdmin.GenerateJSONForPostBrandAdmin(name, description, color), baseUrl + $"brand", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    rest.PutRequest("barre.jpg", baseUrl + $"brand/{id}/picture", $"Bearer {token.token}", true);
                    rest.DeleteRequest("", baseUrl + $"brand/{id}/picturesa", $"Bearer {token.token}");
                    break;
            }
        }
    }
}
