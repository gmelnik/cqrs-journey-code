﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.261
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.Registration.GroupReservation
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute()]
    public partial class RegistrantScenariosForRegisteringAGroupOfAttendeesForAConferenceWhenFewSeatsAreAvailableInAllTheSeatTypesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GroupRegistrationReservationWithPartialAvailability.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Registrant scenarios for registering a group of Attendees for a conference when f" +
                    "ew Seats are available in all the Seat Types", "In order to register for conference a group of Attendees\r\nAs a Registrant\r\n  I wa" +
                    "nt to be able to select Order Items from one or many of the available and or wai" +
                    "tlisted Order Items and make a Reservation", ProgrammingLanguage.CSharp, new string[] {
                        "Ignore"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Registrant scenarios for registering a group of Attendees for a conference when f" +
                            "ew Seats are available in all the Seat Types")))
            {
                Conference.Specflow.Features.Registration.GroupReservation.RegistrantScenariosForRegisteringAGroupOfAttendeesForAConferenceWhenFewSeatsAreAvailableInAllTheSeatTypesFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 22
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "rate",
                        "quota"});
            table1.AddRow(new string[] {
                        "General admission",
                        "$199",
                        "100"});
            table1.AddRow(new string[] {
                        "CQRS Workshop",
                        "$500",
                        "100"});
            table1.AddRow(new string[] {
                        "Additional cocktail party",
                        "$50",
                        "100"});
#line 23
 testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference with th" +
                    "e slug code GroupRegPartial", ((string)(null)), table1);
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("All the Order Items are offered to be waitlisted and all are selected, then all g" +
            "et confirmed")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Registrant scenarios for registering a group of Attendees for a conference when f" +
            "ew Seats are available in all the Seat Types")]
        public virtual void AllTheOrderItemsAreOfferedToBeWaitlistedAndAllAreSelectedThenAllGetConfirmed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All the Order Items are offered to be waitlisted and all are selected, then all g" +
                    "et confirmed", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line 22
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table2.AddRow(new string[] {
                        "General admission",
                        "3"});
            table2.AddRow(new string[] {
                        "CQRS Workshop",
                        "1"});
            table2.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 33
 testRunner.Given("the list of Order Items offered to be waitlisted and selected by the Registrant", ((string)(null)), table2);
#line 38
 testRunner.When("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table3.AddRow(new string[] {
                        "General admission",
                        "3"});
            table3.AddRow(new string[] {
                        "CQRS Workshop",
                        "1"});
            table3.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 39
 testRunner.Then("these Order Itmes get confirmed being waitlisted", ((string)(null)), table3);
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("2 the Order Items are available and 1 waitlisted, 1 becomes partially available,")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Registrant scenarios for registering a group of Attendees for a conference when f" +
            "ew Seats are available in all the Seat Types")]
        public virtual void _2TheOrderItemsAreAvailableAnd1Waitlisted1BecomesPartiallyAvailable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2 the Order Items are available and 1 waitlisted, 1 becomes partially available,", ((string[])(null)));
#line 48
this.ScenarioSetup(scenarioInfo);
#line 22
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table4.AddRow(new string[] {
                        "General admission",
                        "7"});
            table4.AddRow(new string[] {
                        "CQRS Workshop",
                        "2"});
#line 50
 testRunner.Given("the selected available Order Items", ((string)(null)), table4);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table5.AddRow(new string[] {
                        "Additional cocktail party",
                        "5"});
#line 54
 testRunner.And("the list of these Order Items offered to be waitlisted and selected by the Regist" +
                    "rant", ((string)(null)), table5);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type"});
            table6.AddRow(new string[] {
                        "General admission"});
#line 57
 testRunner.And("these Seat Types becomes partially unavailable before the Registrant make the res" +
                    "ervation", ((string)(null)), table6);
#line 60
 testRunner.When("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table7.AddRow(new string[] {
                        "General admission",
                        "3"});
            table7.AddRow(new string[] {
                        "Additional cocktail party",
                        "5"});
#line 61
 testRunner.Then("the Registrant is offered to be waitlisted for these Order Items", ((string)(null)), table7);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table8.AddRow(new string[] {
                        "General admission",
                        "4"});
            table8.AddRow(new string[] {
                        "CQRS Workshop",
                        "2"});
#line 65
 testRunner.And("These other Order Items get reserved", ((string)(null)), table8);
#line 69
 testRunner.And("And the total should read $1796");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
