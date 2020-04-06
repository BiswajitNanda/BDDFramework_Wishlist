using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using specflowstepbystep;
using System;
using System.Collections.Generic;
using System.Text;
using specflowstepbystep.Helper;
using OpenQA.Selenium.Interactions;

namespace BDDFramework_WishList.Pages
{
    class LoginPage
    {
        IWebDriver driver;
        IJavaScriptExecutor js;
        Actions actions;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            actions = new Actions(driver);
            js = (IJavaScriptExecutor)driver;            

        }

        [FindsBy(How = How.Id, Using = "PartialLogin_Username")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "PartialLogin_Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/div[1]/div[1]/div/div[1]/form/div[2]/input")]
        public IWebElement Submit { get; set; }

        public void DoLogin(string username,string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
            
            js.ExecuteScript("window.scrollBy(0,200)");
            HelperFunctions.sleep(500);
               actions.MoveToElement(Submit)
                   .DoubleClick()
                   .Build()
                   .Perform();
         
            
        }



        

    }
}
