using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using specflowstepbystep.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Interactions;
using specflowstepbystep.Objectrepo;

namespace BDDFramework_WishList.Pages
{
    class ProductDetailsPage
    {
        IWebDriver driver;
        IJavaScriptExecutor js;
        Actions actions;
        String carlink;

        public ProductDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            actions = new Actions(driver);
            js = (IJavaScriptExecutor)driver;
 
        }

        public void addProduct()
        {
            js.ExecuteScript("window.scrollBy(0,500)");
            HelperFunctions.sleep(500);
            driver.FindElement(By.XPath(Objectrepo.wishlist_loc)).Click();

        }


    }
}
