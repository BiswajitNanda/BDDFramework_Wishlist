using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using specflowstepbystep;
using specflowstepbystep.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDDFramework_WishList.Pages
{
    class SearchPage
    {
        IWebDriver driver;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void GoToSearchPage()
        {
            driver.Navigate().GoToUrl(Config._SearchURL);
        }

        public void GoToProductDetailsPage()
        {
            string carlink = HelperFunctions.get_product_fromjson();
         //   HelperFunctions.sleep(500);
            driver.FindElement(By.PartialLinkText(carlink)).Click();
        }


    }
}
