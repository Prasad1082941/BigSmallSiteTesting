using BigSmallSiteTesting.CommonMethodObject;
using System;
using TechTalk.SpecFlow;

namespace BigSmallSiteTesting.StepDefinations
{
    [Binding]
    public class GiftSiteSteps
    {
        GiftSiteTestingObject siteobj = new GiftSiteTestingObject(); 
        [Given(@"User Clicks on Gift card")]
        public void GivenUserClicksOnGiftCard()
        {
            siteobj.ClickOnGiftCard();
        }
        
        [When(@"User Clicks on price")]
        public void WhenUserClicksOnPrice()
        {
            siteobj.ClickOnPrice();
        }

        [When(@"USer Clicks on Wishlist")]
        public void WhenUSerClicksOnWishlist()
        {
            siteobj.ClickOnWishlit();
        }

      

        [When(@"User Enters PinCode")]
        public void WhenUserEntersPinCode()
        {
            siteobj.EnterPincode();
        }
        
        [When(@"User Clicks on Check Button")]
        public void WhenUserClicksOnCheckButton()
        {
            siteobj.ClickOnCheck();
        }
        
        [When(@"User Clicks on Add to cart")]
        public void WhenUserClicksOnAddToCart()
        {
            siteobj.ClickOnAddToCart();
        }
        
        [Then(@"User Click on Continue Shopping")]
        public void ThenUserClickOnContinueShopping()
        {
            siteobj.ClickOnContinueShopping();
        }
    }
}
