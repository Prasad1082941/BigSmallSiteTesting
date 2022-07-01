using System;
using TechTalk.SpecFlow;
using BigSmallSiteTesting.CommonMethodObjects;

namespace BigSmallSiteTesting.StepDefinitions
{
    [Binding]
    public class CheckFunctionalityOfAllOfItSteps
    {
        AllOfItObject aobj = new AllOfItObject();
        [Given(@"user is on home page")]
        public void GivenUserIsOnHomePage()
        {
            aobj.verifyPage();
        }
        
        [When(@"user click on all of it")]
        public void WhenUserClickOnAllOfIt()
        {
            aobj.ClickAllOfIt();
        }
        
        [When(@"select sort by option from dropdown")]
        public void WhenSelectSortByOptionFromDropdown()
        {
            aobj.Sort();
        }
        
        [When(@"Click on item")]
        public void WhenClickOnItem()
        {
            aobj.ClickOnItem();
        }
        
       
        
        [When(@"click on add to cart")]
        public void WhenClickOnAddToCart()
        {
            aobj.ClickAddToCart();
        }
        
        [When(@"click on continue shopping")]
        public void WhenClickOnContinueShopping()
        {
            aobj.ContinueShopping();
        }
        
        [Then(@"item should be successfully added in cart\.")]
        public void ThenItemShouldBeSuccessfullyAddedInCart_()
        {
            aobj.ViewCart();
        }
    }
}
