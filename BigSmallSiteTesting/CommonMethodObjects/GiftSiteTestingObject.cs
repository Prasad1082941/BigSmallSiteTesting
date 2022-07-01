using BigSmallSiteTesting.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigSmallSiteTesting.CommonMethodObject
{
    public class GiftSiteTestingObject
    {
        public void ClickOnGiftCard()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement GiftCard = BaseClass.driver.FindElement(By.XPath("//*[@id='myheader']/div[1]/header/div[2]/div[2]/div[4]/div/div/a[3]/i"));
            GiftCard.Click();
        }

        public void ClickOnPrice()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement ClickPrice = BaseClass.driver.FindElement(By.XPath("//label[@for='ProductSelect-738195636312-option-title-Rs.+1000']"));
            ClickPrice.Click();
        }
        public void ClickOnWishlit()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement WishList = BaseClass.driver.FindElement(By.XPath("//span[text()='Add to Wishlist']"));
            WishList.Click();
        }
        public void EnterPincode()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement Pincode = BaseClass.driver.FindElement(By.XPath("//*[@id='PostalCode']"));
            Pincode.SendKeys("411051");


        }
        public void ClickOnCheck()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement Check = BaseClass.driver.FindElement(By.XPath("//*[@id='cod-cheker']/button"));
            Check.Click();
        }

        public void ClickOnAddToCart()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement AddToCart = BaseClass.driver.FindElement(By.XPath("//*[@id='AddToCartForm-738195636312']/button/span"));
            AddToCart.Click();

        }
         public void ClickOnContinueShopping()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement ContinueShopping = BaseClass.driver.FindElement(By.XPath("//*[@id='CartDrawer']/form/div[2]/div[3]/a"));
            ContinueShopping.Click();
        }


       

    }
}
