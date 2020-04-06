using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using specflowstepbystep;
using specflowstepbystep.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDDFramework_WishList.Pages
{
    class MyGaragePage
    {
        IWebDriver driver;
        IJavaScriptExecutor js;

        public MyGaragePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            js = (IJavaScriptExecutor)driver;
        }
       
        [FindsBy(How = How.XPath, Using = "//*[@id='whatchlist_slider']/div/div/div/div[1]/p/a/span")]
        public IWebElement remove { get; set; }

        public void GoToMyGaragePage()
        {
            driver.Navigate().GoToUrl(Config._MyGarageURL);
        }

        public string Garageentries()
        {
            return driver.PageSource;
        }

        public void removecarfromwishlist()
        {
            HelperFunctions.sleep(200);
            js.ExecuteScript("window.scrollBy(0,300)");
            remove.Click();
            HelperFunctions.sleep(200);
            
        }
        

    }
}
