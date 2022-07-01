using BigSmallSiteTesting.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigSmallSiteTesting.CommonMethodObjects
{
    class CorporateObject
    {
        public void homepage()
        {
            IWebElement homePage = BaseClass.driver.FindElement(By.XPath("//*[@id='myheader']/div[1]/div/div/ul/li[4]/a"));
           
        }

        public void Click()
        {
            IWebElement home = BaseClass.driver.FindElement(By.XPath("//*[@id='myheader']/div[1]/div/div/ul/li[4]/a"));
            home.Click();
        }
        public void Name()
        {
            IWebElement Name = BaseClass.driver.FindElement(By.Id("contactFormName"));
            Name.SendKeys("Anup");
        }
        public void Email()
        {
            IWebElement Email = BaseClass.driver.FindElement(By.XPath("//*[@id='contactFormEmail']"));
            Email.SendKeys("Anup@gmail.com");
        }
        public void Phone()
        {
            IWebElement Phone = BaseClass.driver.FindElement(By.XPath("//*[@id='contactFormPhone']"));
            Phone.SendKeys("9876543210");
        }
        public void Enquiry()
        {
            IWebElement Enquiry = BaseClass.driver.FindElement(By.XPath("//*[@id='contactFormMessage']"));
            Enquiry.SendKeys("Toys");
        }
        public void Submit()
        {
            IWebElement Submitbtn = BaseClass.driver.FindElement(By.XPath("//input[@type='submit'and @value='submit']"));
            Submitbtn.Click();

            // SreenShot
           // ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile("Test.Png", ScreenshotImageFormat.Png);
        }














        /*   public void verifymessage()
           {
               bool visible = true;
               IWebElement message = BaseClass.Driver.FindElement(By.XPath("//*[@id='contact_form']/p"));
               visible = message.Displayed;
               Assert.AreEqual(visible, true);
           }
        */
    }
}
