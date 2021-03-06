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
namespace Conference.Specflow.Features.Registration.AllFeaturesEndToEnd
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class SelfRegistrantEndToEndScenarioForMakingARegistrationForAConferenceSiteHappyPathFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SelfRegistrationEndToEndHappy.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Self Registrant end to end scenario for making a Registration for a Conference si" +
                    "te (happy path)", "In order to register for a conference\r\nAs an Attendee\r\nI want to be able to regis" +
                    "ter for the conference, pay for the Registration Order and associate myself with" +
                    " the paid Order automatically", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Self Registrant end to end scenario for making a Registration for a Conference si" +
                            "te (happy path)")))
            {
                Conference.Specflow.Features.Registration.AllFeaturesEndToEnd.SelfRegistrantEndToEndScenarioForMakingARegistrationForAConferenceSiteHappyPathFeature.FeatureSetup(null);
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
#line 19
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
#line 20
 testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference with th" +
                    "e slug code SelfRegE2Ehappy", ((string)(null)), table1);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table2.AddRow(new string[] {
                        "General admission",
                        "1"});
            table2.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 25
 testRunner.And("the selected Order Items", ((string)(null)), table2);
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Make a reservation with the selected Order Items")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Self Registrant end to end scenario for making a Registration for a Conference si" +
            "te (happy path)")]
        public virtual void MakeAReservationWithTheSelectedOrderItems()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Make a reservation with the selected Order Items", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line 19
this.FeatureBackground();
#line 35
 testRunner.When("the Registrant proceed to make the Reservation");
#line 36
 testRunner.Then("the Reservation is confirmed for all the selected Order Items");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type"});
            table3.AddRow(new string[] {
                        "General admission"});
            table3.AddRow(new string[] {
                        "Additional cocktail party"});
#line 37
 testRunner.And("these Order Items should be reserved", ((string)(null)), table3);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type"});
            table4.AddRow(new string[] {
                        "CQRS Workshop"});
#line 41
 testRunner.And("these Order Items should not be reserved", ((string)(null)), table4);
#line 44
 testRunner.And("the total should read $249");
#line 45
 testRunner.And("the countdown started");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Checkout:Registrant Details")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Self Registrant end to end scenario for making a Registration for a Conference si" +
            "te (happy path)")]
        public virtual void CheckoutRegistrantDetails()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Checkout:Registrant Details", ((string[])(null)));
#line 48
this.ScenarioSetup(scenarioInfo);
#line 19
this.FeatureBackground();
#line 49
 testRunner.Given("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "First name",
                        "Last name",
                        "email address"});
            table5.AddRow(new string[] {
                        "Gregory",
                        "Weber",
                        "gregoryweber@contoso.com"});
#line 50
 testRunner.And("the Registrant enter these details", ((string)(null)), table5);
#line 53
 testRunner.When("the Registrant proceed to Checkout:Payment");
#line 54
 testRunner.Then("the payment options should be offered for a total of $249");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Checkout:Payment and sucessfull Order completed")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Self Registrant end to end scenario for making a Registration for a Conference si" +
            "te (happy path)")]
        public virtual void CheckoutPaymentAndSucessfullOrderCompleted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Checkout:Payment and sucessfull Order completed", ((string[])(null)));
#line 56
this.ScenarioSetup(scenarioInfo);
#line 19
this.FeatureBackground();
#line 57
 testRunner.Given("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "First name",
                        "Last name",
                        "email address"});
            table6.AddRow(new string[] {
                        "Gregory",
                        "Weber",
                        "gregoryweber@contoso.com"});
#line 58
 testRunner.And("the Registrant enter these details", ((string)(null)), table6);
#line 61
 testRunner.And("the Registrant proceed to Checkout:Payment");
#line 62
 testRunner.When("the Registrant proceed to confirm the payment");
#line 63
    testRunner.Then("the message \'You will receive a confirmation e-mail in a few minutes.\' will show " +
                    "up");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table7.AddRow(new string[] {
                        "General admission",
                        "1"});
            table7.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 64
 testRunner.And("the Order should be created with the following Order Items", ((string)(null)), table7);
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("AllocateSeats")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Self Registrant end to end scenario for making a Registration for a Conference si" +
            "te (happy path)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute()]
        public virtual void AllocateSeats()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("AllocateSeats", new string[] {
                        "Ignore"});
#line 71
this.ScenarioSetup(scenarioInfo);
#line 19
this.FeatureBackground();
#line 72
testRunner.Given("the ConfirmSuccessfulRegistration for the selected Order Items");
#line 73
testRunner.And("the Order Access code is 6789");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "First name",
                        "Last name",
                        "email address",
                        "Seat type"});
            table8.AddRow(new string[] {
                        "Gregory",
                        "Weber",
                        "gregoryweber@contoso.com",
                        "General admission"});
            table8.AddRow(new string[] {
                        "Gregory",
                        "Weber",
                        "gregoryweber@contoso.com",
                        "Additional cocktail party"});
#line 74
testRunner.And("the Registrant assign the purchased seats to attendees as following", ((string)(null)), table8);
#line 78
testRunner.Then("the Regsitrant should be get a Seat Assignment confirmation");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Access code",
                        "email address",
                        "Seat type"});
            table9.AddRow(new string[] {
                        "6789-1",
                        "gregoryweber@contoso.com",
                        "General admission"});
            table9.AddRow(new string[] {
                        "6789-2",
                        "gregoryweber@contoso.com",
                        "Additional cocktail party"});
#line 79
testRunner.And("the Attendees should get an email informing about the conference and the Seat Typ" +
                    "e with Seat Access Code", ((string)(null)), table9);
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Make a reservation with the selected Order Items and a Promo Code")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Self Registrant end to end scenario for making a Registration for a Conference si" +
            "te (happy path)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute()]
        public virtual void MakeAReservationWithTheSelectedOrderItemsAndAPromoCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Make a reservation with the selected Order Items and a Promo Code", new string[] {
                        "Ignore"});
#line 87
this.ScenarioSetup(scenarioInfo);
#line 19
this.FeatureBackground();
#line 88
 testRunner.Given("the Registrant apply the \'COPRESENTER\' Promotional Code");
#line 89
 testRunner.And("the \'COPRESENTER\' Promo code should show a value of -$5");
#line 90
 testRunner.When("the Registrant proceed to make the Reservation");
#line 91
 testRunner.Then("the Reservation is confirmed for all the selected Order Items");
#line 92
 testRunner.And("the total should read $244");
#line 93
 testRunner.And("the countdown started");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
