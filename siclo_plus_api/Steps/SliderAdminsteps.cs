using siclo_plus_api.Helpers;
using siclo_plus_api.Hooks;
using siclo_plus_api.JSON;
using siclo_plus_api.Request;
using System;
using siclo_plus_api.Steps;
using TechTalk.SpecFlow;
using BearerToken = siclo_plus_api.Models.Token;

namespace siclo_plus_api
{
    [Binding]
    public class SliderAdminsteps : Base
    {
        private readonly PoolDataContext context;
        private readonly BearerToken token;
        public static string id;
        public SliderAdminsteps(PoolDataContext context, ScenarioContext scenarioContext, FeatureContext featureContext, BearerToken token) : base(scenarioContext, featureContext)
        {
            this.context = context;
            this.token = token;
        }

        [Given(@"Send the post request for slider_admin (.*)")]
        public void GivenSendThePostRequestForSlider_Admin(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {

                case 201:
                    rest.PostRequest(SliderAdmin.GenerateJSONForPostSliderAdmin() ,baseUrl + $"slider", $"Bearer {token.token}", false);
                    break;
                case 403:
                    rest.PostRequest(SliderAdmin.GenerateJSONForPostSliderAdmin() ,baseUrl + $"slider", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PostRequest(SliderAdmin.GenerateJSONForPostSliderAdmin() ,baseUrl + $"slider123", $"Bearer {token.token}",false);
                    break;
            }
        }
        [Given(@"Send the put request for slider_admin_id (.*)")]
        public void GivenSendThePutRequestForSlider_Admin_Id(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {
                case 201:
                    rest.PutRequest(SliderAdmin.GenerateJSONForPutSliderAdmin() ,baseUrl + $"slider/b634c28e-4b9a-40f3-8060-bdc26d779093", $"Bearer {token.token}", false);
                    break;
                case 403:
                    rest.PutRequest(SliderAdmin.GenerateJSONForPutSliderAdmin() ,baseUrl + $"slider/b634c28e-4b9a-40f3-8060-bdc26d779093", $"Bearer 123",false);
                    break;
                case 404:
                    rest.PutRequest(SliderAdmin.GenerateJSONForPutSliderAdmin() ,baseUrl + $"slSDider/b634c28e-4b9a-40f3-806uuihiygy3", $"Bearer {token.token}",false);
                    break;
            }
        }
        [Given(@"Send the delete request for slider_admin_id (.*)")]
        public void GivenSendTheDeleteRequestForSlider_Admin_Id(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {

                case 200:
                    rest.DeleteRequest(SliderAdmin.GenerateJSONForDeleteSliderAdmin() ,baseUrl + $"slider/b634c28e-4b9a-40f3-8060-bdc26d779093", $"Bearer {token.token}");
                    break;
                case 403:
                    rest.DeleteRequest(SliderAdmin.GenerateJSONForDeleteSliderAdmin(), baseUrl + $"slider/b634c28e-4b9a-40f3-8060-bdc26d779093", $"Bearer 123");
                    break;
                case 404:
                    rest.DeleteRequest(SliderAdmin.GenerateJSONForDeleteSliderAdmin(), baseUrl + $"Slider_Admin/b634c28e-4b9a-", $"Bearer {token.token}");
                    break;
            }
        }
        [Given(@"Send the post priority request for slider_admin (.*)")]
        public void GivenSendThePostPriorityRequestForSlider_Admin(int response)
        {
            Rest rest = new Rest();
            switch (response)
            {

                case 200:
                    rest.PostRequest(SliderAdmin.GenerateJSONForPostPrioritySliderAdmin(), baseUrl + $"Slider_Admin/priority", $"Bearer {token.token}", false);
                    break;
                case 401:
                    rest.PostRequest(SliderAdmin.GenerateJSONForPostPrioritySliderAdmin(), baseUrl + $"Slider_Admin/priority", $"Bearer 123", false);
                    break;
                case 404:
                    rest.PostRequest(SliderAdmin.GenerateJSONForPostPrioritySliderAdmin(), baseUrl + $"Slider_Admin/b634c28e-4b9a-", $"Bearer {token.token}",false);
                    break;
            }
        }

    }
}
