using System;
using System.Collections.Generic;
using System.Text;
using BigSmallSiteTesting.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BigSmallSiteTesting.CommonMethodObjects
{
   public  class AllOfItObject
    {
        
        public void verifyPage() { }
        public void ClickAllOfIt()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement allofit = BaseClass.driver.FindElement(By.XPath("//*[@id='myheader']/div[1]/div/div/ul/li[7]/a"));
            allofit.Click();
        }
        public void Sort()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            SelectElement sort = new SelectElement(BaseClass.driver.FindElement
                (By.XPath("//select[@name='sortBy']")));
            sort.SelectByIndex(2);
        }
        public void ClickOnItem()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement item = BaseClass.driver.FindElement(By.XPath("//a[@href='/products/dumbbell-water-bottle']"));
            item.Click();
        }
      
        public void ClickAddToCart()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement addtocart = BaseClass.driver.FindElement
                (By.Name("add"));
            addtocart.Click();
        }
        public void ContinueShopping()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement shopping = BaseClass.driver.FindElement(By.XPath("//a[@href='javascript:void(0);']"));
           shopping.Click();
        }
        public void ViewCart()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement view = BaseClass.driver.FindElement(By.XPath("//span[text()='cart']"));
            view.Click();
        }
    }
}
