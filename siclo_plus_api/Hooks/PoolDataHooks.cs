using BoDi;
using Newtonsoft.Json;
using siclo_plus_api.Helpers;
using siclo_plus_api.Request;
using siclo_plus_api.Steps;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using RestSharp;
using System.Threading.Tasks;
using siclo_plus_api.Models;
using AventStack.ExtentReports.Gherkin.Model;
using System.Diagnostics;

namespace siclo_plus_api.Hooks
{
    public class PoolDataContext
    {
        public string Data { get; set; }
        public int ScenarioNumber { get; set; }
        public string Name { get; set; }

    }
    [Binding]
    public class PoolDataHooks
    {
        private readonly PoolDataContext context;
        private readonly IObjectContainer objectContainer;
        private static Token token;


        public PoolDataHooks(PoolDataContext context)
        {
            this.context = context;
        }
        [BeforeScenario]

        public void BeforeScenario(ScenarioContext scenarioContext, FeatureContext featureContext, IObjectContainer container)
        {
            container.RegisterInstanceAs<Token>(token);
            Base.scenarioName = ScenarioContext.Current.ScenarioInfo.Title;
        }
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            string value = Environment.GetEnvironmentVariable("BASE_URL");
            Base.baseUrl = value;
            if (String.IsNullOrEmpty(value) || (!value.Contains("https://api.")))
            {
                Base.baseUrl = "https://api.dev.siclo.plus/";
            }

            Rest rest = new Rest();
            rest.PostRequest(@"{""email"": ""javier@siclo.com"",""password"": ""javier123""}", Base.baseUrl + $"auth/login", "", false);
            token = JsonConvert.DeserializeObject<Token>(Rest.response.Content);
        }
        [AfterScenario]
        public static void AfterScenario()
        {
          //  Helper.CreateJsonResponseFile();
        }
    }
}
