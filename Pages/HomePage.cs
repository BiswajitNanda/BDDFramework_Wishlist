using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using specflowstepbystep;
using specflowstepbystep.Objectrepo;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDDFramework_WishList.Pages
{
    class HomePage
    {
        IWebDriver driver;

        [FindsBy(How= How.PartialLinkText,Using = "Log" )]
        public IWebElement login { get; set; }

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
          //  driver.Navigate().GoToUrl(Config._HomePageURL);
        }

        public string getTitle()
        {
            return driver.Title;
        }
        
        public void clickLoginPageLink()
        {
            login.Click();
            
        }
    }
}
