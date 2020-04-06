using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace BDDFramework_WishList.Pages
{
    class BasePage
    {
        public IWebDriver driver = null;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

    }
}
