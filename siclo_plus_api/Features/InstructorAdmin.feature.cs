﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace siclo_plus_api.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("InstructorAdmin", Description="API endpoint  for instructor admin", SourceFile="Features\\InstructorAdmin.feature", SourceLine=0)]
    public partial class InstructorAdminFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "InstructorAdmin.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "InstructorAdmin", "API endpoint  for instructor admin", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void _01_Post_Instructor(string response, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "APIInstructorAdmin"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("response", response);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01_Post_instructor", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
 testRunner.Given(string.Format("Send the post request for instructor {0}", response), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.Then(string.Format("The response should match with the expected results {0}", response), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("01_Post_instructor, 200", new string[] {
                "APIInstructorAdmin"}, SourceLine=10)]
        public virtual void _01_Post_Instructor_200()
        {
#line 5
this._01_Post_Instructor("200", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("01_Post_instructor, 400", new string[] {
                "APIInstructorAdmin"}, SourceLine=10)]
        public virtual void _01_Post_Instructor_400()
        {
#line 5
this._01_Post_Instructor("400", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("01_Post_instructor, 401", new string[] {
                "APIInstructorAdmin"}, SourceLine=10)]
        public virtual void _01_Post_Instructor_401()
        {
#line 5
this._01_Post_Instructor("401", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("01_Post_instructor, 404", new string[] {
                "APIInstructorAdmin"}, SourceLine=10)]
        public virtual void _01_Post_Instructor_404()
        {
#line 5
this._01_Post_Instructor("404", ((string[])(null)));
#line hidden
        }
        
        public virtual void _02_Put_Instructor_Id(string response, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "APIInstructorAdmin"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("response", response);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02_Put_instructor_id", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 18
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 19
 testRunner.Given(string.Format("Send the put request for instructor_id {0}", response), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 20
 testRunner.Then(string.Format("The response should match with the expected results {0}", response), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("02_Put_instructor_id, 200", new string[] {
                "APIInstructorAdmin"}, SourceLine=23)]
        public virtual void _02_Put_Instructor_Id_200()
        {
#line 18
this._02_Put_Instructor_Id("200", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("02_Put_instructor_id, 400", new string[] {
                "APIInstructorAdmin"}, SourceLine=23)]
        public virtual void _02_Put_Instructor_Id_400()
        {
#line 18
this._02_Put_Instructor_Id("400", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("02_Put_instructor_id, 401", new string[] {
                "APIInstructorAdmin"}, SourceLine=23)]
        public virtual void _02_Put_Instructor_Id_401()
        {
#line 18
this._02_Put_Instructor_Id("401", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("02_Put_instructor_id, 404", new string[] {
                "APIInstructorAdmin"}, SourceLine=23)]
        public virtual void _02_Put_Instructor_Id_404()
        {
#line 18
this._02_Put_Instructor_Id("404", ((string[])(null)));
#line hidden
        }
        
        public virtual void _03_Put_Instructor_Id_Picture(string response, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "APIInstructorAdmin"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("response", response);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("03_Put_instructor_id_picture", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 30
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 31
 testRunner.Given(string.Format("Send the put request for instructor id picture {0}", response), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 32
 testRunner.Then(string.Format("The response should match with the expected results {0}", response), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("03_Put_instructor_id_picture, 200", new string[] {
                "APIInstructorAdmin"}, SourceLine=35)]
        public virtual void _03_Put_Instructor_Id_Picture_200()
        {
#line 30
this._03_Put_Instructor_Id_Picture("200", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("03_Put_instructor_id_picture, 401", new string[] {
                "APIInstructorAdmin"}, SourceLine=35)]
        public virtual void _03_Put_Instructor_Id_Picture_401()
        {
#line 30
this._03_Put_Instructor_Id_Picture("401", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("03_Put_instructor_id_picture, 404", new string[] {
                "APIInstructorAdmin"}, SourceLine=35)]
        public virtual void _03_Put_Instructor_Id_Picture_404()
        {
#line 30
this._03_Put_Instructor_Id_Picture("404", ((string[])(null)));
#line hidden
        }
        
        public virtual void _05_Delete_Instructor_Id(string response, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "APIInstructorAdmin"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("response", response);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("05_Delete_instructor_id", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 42
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 43
 testRunner.Given(string.Format("Send the delete request for instructor id {0}", response), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 44
 testRunner.Then(string.Format("The response should match with the expected results {0}", response), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("05_Delete_instructor_id, 204", new string[] {
                "APIInstructorAdmin"}, SourceLine=47)]
        public virtual void _05_Delete_Instructor_Id_204()
        {
#line 42
this._05_Delete_Instructor_Id("204", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("05_Delete_instructor_id, 400", new string[] {
                "APIInstructorAdmin"}, SourceLine=47)]
        public virtual void _05_Delete_Instructor_Id_400()
        {
#line 42
this._05_Delete_Instructor_Id("400", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("05_Delete_instructor_id, 401", new string[] {
                "APIInstructorAdmin"}, SourceLine=47)]
        public virtual void _05_Delete_Instructor_Id_401()
        {
#line 42
this._05_Delete_Instructor_Id("401", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("05_Delete_instructor_id, 404", new string[] {
                "APIInstructorAdmin"}, SourceLine=47)]
        public virtual void _05_Delete_Instructor_Id_404()
        {
#line 42
this._05_Delete_Instructor_Id("404", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
