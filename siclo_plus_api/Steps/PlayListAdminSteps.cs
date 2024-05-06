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
    public class PlayListAdminSteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public static string idInstructor;
        public static string idBrand;
        public static string idVideo;
        public static string id;
        public PlayListAdminSteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }
        [Given(@"Send the post request for play list admin (.*)")]
        public void GivenSendThePostRequestForPlayListAdmin(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    //GetInstructorID
                    rest.GetRequest(baseUrl + "instructor", $"Bearer {token.token}", "");
                    idInstructor = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "[");
                    //GetBrandID
                    rest.GetRequest(baseUrl + $"brand", $"Bearer {token.token}", "");
                    idBrand = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "[");
                    //GetVideoID
                    rest.GetRequest(baseUrl + $"video", $"Bearer {token.token}", "");
                    idVideo = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "videos");
                    //PostPlaylist
                    rest.PostRequest(PlayListAdmin.GenerateJSONForPostPlaylistAdmin(idVideo, idInstructor, idBrand), baseUrl + $"playlist", $"Bearer {token.token}", false);
                    id = Helper.GetItemFromResponse("id", Rest.response.Content.ToString(), "");
                    break;
                case 400:
                    rest.PostRequest("{}", baseUrl + $"playlist", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PostRequest(PlayListAdmin.GenerateJSONForPostPlaylistAdmin(idVideo, idInstructor, idBrand), baseUrl + $"playlist", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PostRequest(PlayListAdmin.GenerateJSONForPostPlaylistAdmin(idVideo, idInstructor, idBrand), baseUrl + $"playlistess", $"Bearer {token.token}", false);
                    break;
            }
        }
        [Given(@"Send the put request for play list admin (.*)")]
        public void GivenSendThePutRequestForPlayListAdmin(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.PutRequest(PlayListAdmin.GenerateJSONForPutPlaylistAdmin(), baseUrl + $"playlist/{id}", $"Bearer {token.token}", false);
                    break;
                case 400:
                    rest.PutRequest("{}", baseUrl + $"playlist/{id}", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PutRequest(PlayListAdmin.GenerateJSONForPutPlaylistAdmin(), baseUrl + $"playlist/{id}", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PutRequest(PlayListAdmin.GenerateJSONForPutPlaylistAdmin(), baseUrl + $"playlistes/{id}", $"Bearer {token.token}", false);
                    break;
            }
        }
        [Given(@"Send the delete request for play list admin (.*)")]
        public void GivenSendTheDeleteRequestForPlayListAdmin(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 204:
                    rest.DeleteRequest("", baseUrl + $"playlist/{id}", $"Bearer {token.token}");
                    break;
                case 400:
                    rest.DeleteRequest("{}", baseUrl + $"playlist/{id}", $"Bearer {token.token}");
                    break;
                case 401:
                    rest.DeleteRequest("", baseUrl + $"playlist/{id}", $"Bearer 123");
                    break;
                case 404:
                    rest.DeleteRequest("", baseUrl + $"playlistes/{id}", $"Bearer {token.token}");
                    break;
            }
        }
        [Given(@"Send the put request for play list items admin (.*)")]
        public void GivenSendThePutRequestForPlayListItemsAdmin(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.PutRequest(PlayListAdmin.GenerateJSONForPutPlaylistItemsAdmin(idVideo, idInstructor, idBrand), baseUrl + $"playlist/{id}/items", $"Bearer {token.token}", false);
                    break;
                case 400:
                    rest.PutRequest("{}", baseUrl + $"playlist/{id}/items", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PutRequest(PlayListAdmin.GenerateJSONForPutPlaylistItemsAdmin(idVideo, idInstructor, idBrand), baseUrl + $"playlist/{id}/items", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PutRequest(PlayListAdmin.GenerateJSONForPutPlaylistItemsAdmin(idVideo, idInstructor, idBrand), baseUrl + $"playlistess/{id}/items", $"Bearer {token.token}", false);
                    break;
            }
        }
        [Given(@"Send the put request for play list pictures admin (.*)")]
        public void GivenSendThePutRequestForPlayListPicturesAdmin(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 200:
                    rest.PutRequest("{}", baseUrl + $"playlist/{id}/picture", $"Bearer {token.token}", true);
                    break;
                case 400:
                    rest.PutRequest("", baseUrl + $"playlist/{id}/picture", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PutRequest("", baseUrl + $"playlist/{id}/picture", $"Bearer 123", true);
                    break;
                case 404:
                    rest.PutRequest("", baseUrl + $"playlistes/{id}/pictures", $"Bearer {token.token}", true);
                    break;
            }
        }

    }
}
