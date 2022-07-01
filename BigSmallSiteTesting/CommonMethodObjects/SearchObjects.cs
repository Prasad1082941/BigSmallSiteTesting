using System;
using System.Collections.Generic;
using System.Text;
using BigSmallSiteTesting.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace BigSmallSiteTesting.CommonMethodObjects
{
   public class SearchObjects
    {
        public void HomePage()
        {
            BaseClass.driver.Navigate().GoToUrl("https://www.bigsmall.in/");
            BaseClass.driver.Manage().Window.Maximize();
        }
        public void OnSitePage()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
           IWebElement VerifySearch= BaseClass.driver.FindElement(By.XPath("//*[@id='myheader']/div[1]/header/div[2]/div[2]/div[1]/div/a[1]/img[2]"));
           // VerifySearch.Click();
        }
        public void ClickOnSearch(string SearchData)
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            IWebElement SearchBar = BaseClass.driver.FindElement(By.Name("q"));
            SearchBar.SendKeys(SearchData);
            //SearchBar.Click();


        }
        public void VerifyResult()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            IWebElement SearchBar = BaseClass.driver.FindElement(By.Name("q"));
            SearchBar.Click();
            
        }

       
    }
}
