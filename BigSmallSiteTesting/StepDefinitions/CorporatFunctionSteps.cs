using System;
using TechTalk.SpecFlow;
using BigSmallSiteTesting.CommonMethodObjects;

namespace BigSmallSiteTesting.StepDefinitions
{
    [Binding]
    public class CorporatFunctionSteps
    {
        CorporateObject obj = new CorporateObject();
        [Given(@"User is home page")]
        public void GivenUserIsHomePage()
        {
              obj.homepage();
        }

        [When(@"User click on Coproate")]
        public void WhenUserClickOnCoproate()
        {
           obj.Click();
        }

        [When(@"User Enter fullname")]
        public void WhenUserEnterFullname()
        {
            obj.Name();

        }

        [When(@"User Enter Email-id")]
        public void WhenUserEnterEmail_Id()
        {
            obj.Email();
        }

        [When(@"User Enter PhoneNo")]
        public void WhenUserEnterPhoneNo()
        {
           obj.Phone();
        }

        [When(@"User Fill Enquiry")]
        public void WhenUserFillEnquiry()
        {
            obj.Enquiry();
        }

        [When(@"Click on submit")]
        public void WhenClickOnSubmit()
        {
            obj.Submit();
        }

        [Then(@"Verify the messeage")]
        public void ThenVerifyTheMesseage()
        {
            // BigObj.verifymessage();
        }
    }
}
