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
    public class InstructorAdminSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public static string id;
        Rest rest = new Rest();
        public InstructorAdminSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }
        [Given(@"Send the post request for instructor (.*)")]
        public void GivenSendThePostRequestForInstructor(int response)
        {
            switch (response)
            {
                case 200:
                    rest.PostRequest(InstructorAdmin.GenerateJSONForPostInstructorAdmin(), baseUrl + $"instructor", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    break;
                case 400:
                    rest.PostRequest("{}", baseUrl + $"instructor", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PostRequest(InstructorAdmin.GenerateJSONForPostInstructorAdmin(), baseUrl + $"instructor", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PostRequest(InstructorAdmin.GenerateJSONForPostInstructorAdmin(), baseUrl + $"instructoress", $"Bearer {token.token}", false);
                    break;
            }
        }

        [Given(@"Send the put request for instructor_id (.*)")]
        public void GivenSendThePutRequestForInstructor_Id(int response)
        {
            switch (response)
            {
                case 200:
                    if (id.Equals(""))
                    {
                        rest.PostRequest(InstructorAdmin.GenerateJSONForPostInstructorAdmin(), baseUrl + $"instructor", $"Bearer {token.token}", false);
                        id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    }
                    rest.PutRequest(InstructorAdmin.GenerateJSONForPutInstructorAdmin(), baseUrl + $"instructor/{id}", $"Bearer {token.token}", false);

                    break;
                case 400:
                    rest.PutRequest("", baseUrl + $"instructor/{id}", $"Bearer {token.token}", false);
                    break;
                case 401:
                    if (id.Equals(""))
                    {
                        rest.PostRequest(InstructorAdmin.GenerateJSONForPostInstructorAdmin(), baseUrl + $"instructor", $"Bearer {token.token}", false);
                        id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    }
                    rest.PutRequest(InstructorAdmin.GenerateJSONForPutInstructorAdmin(), baseUrl + $"instructor/{id}", $"Bearer 123", false);
                    break;
                case 404:
                    if (id.Equals(""))
                    {
                        rest.PostRequest(InstructorAdmin.GenerateJSONForPostInstructorAdmin(), baseUrl + $"instructor", $"Bearer {token.token}", false);
                        id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    }
                    rest.PutRequest(InstructorAdmin.GenerateJSONForPutInstructorAdmin(), baseUrl + $"instructoress/{id}", $"Bearer {token.token}", false);
                    break;
            }
        }

        [Given(@"Send the put request for instructor id picture (.*)")]
        public void GivenSendThePutRequestForInstructorIdPicture(int response)
        {
            switch (response)
            {
                case 200:
                    if (id.Equals(""))
                    {
                        rest.PostRequest(InstructorAdmin.GenerateJSONForPostInstructorAdmin(), baseUrl + $"instructor", $"Bearer {token.token}", false);
                        id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    }
                    rest.PutRequest("barre.jpg", baseUrl + $"instructor/{id}/picture/facePhoto", $"Bearer {token.token}", true);
                    break;
                case 400:
                    rest.PutRequest("{}", baseUrl + $"instructor/{id}/picture", $"Bearer {token.token}", false);
                    break;
                case 401:
                    if (id.Equals(""))
                    {
                        rest.PostRequest(InstructorAdmin.GenerateJSONForPostInstructorAdmin(), baseUrl + $"instructor", $"Bearer {token.token}", false);
                        id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    }
                    rest.PutRequest("barre.jpg", baseUrl + $"instructor/{id}/picture/facePhoto", $"Bearer 123", true);
                    break;
                case 404:
                    if (id.Equals(""))
                    {
                        rest.PostRequest(InstructorAdmin.GenerateJSONForPostInstructorAdmin(), baseUrl + $"instructor", $"Bearer {token.token}", false);
                        id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    }
                    rest.PutRequest("barre.jpg", baseUrl + $"instructoress/{id}/picturess/facePhotoss", $"Bearer {token.token}", true);
                    break;
            }
        }

        [Given(@"Send the delete request for instructor id (.*)")]
        public void GivenSendTheDeleteRequestForInstructorId(int response)
        {
            switch (response)
            {
                case 204:
                    if (id.Equals(""))
                    {
                        rest.PostRequest(InstructorAdmin.GenerateJSONForPostInstructorAdmin(), baseUrl + $"instructor", $"Bearer {token.token}", false);
                        id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    }
                    rest.DeleteRequest("", baseUrl + $"instructor/{id}", $"Bearer {token.token}");
                    break;
                case 400:
                    if (id.Equals(""))
                    {
                        rest.PostRequest(InstructorAdmin.GenerateJSONForPostInstructorAdmin(), baseUrl + $"instructor", $"Bearer {token.token}", false);
                        id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    }
                    rest.DeleteRequest("{}", baseUrl + $"instructor/{id}", $"");
                    break;
                case 401:
                    if (id.Equals(""))
                    {
                        rest.PostRequest(InstructorAdmin.GenerateJSONForPostInstructorAdmin(), baseUrl + $"instructor", $"Bearer {token.token}", false);
                        id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    }
                    rest.DeleteRequest("", baseUrl + $"instructor/{id}", $"Bearer 123 {token.token}");
                    break;
                case 404:
                    if (id.Equals(""))
                    {
                        rest.PostRequest(InstructorAdmin.GenerateJSONForPostInstructorAdmin(), baseUrl + $"instructor", $"Bearer {token.token}", false);
                        id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    }
                    rest.DeleteRequest("", baseUrl + $"instructoress/{id}", $"Bearer {token.token}");
                    break;
            }
        }
    }
}
