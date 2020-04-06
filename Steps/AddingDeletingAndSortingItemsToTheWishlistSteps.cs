using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Interactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BDDFramework_WishList.Pages;
using SeleniumExtras.PageObjects;

namespace specflowstepbystep
{
    [Binding]
    public class AddingDeletingAndSortingItemsToTheWishlistSteps
    {
        IWebDriver driver;
        IJavaScriptExecutor js;
        Actions actions;
        string carlink;
        bool productexists;

        HomePage homepage;
        LoginPage loginpage;
        MyGaragePage garagepage;
        SearchPage searchpage;
        ProductDetailsPage proddetailspage; 

        [Before]
        public void SetUp()
        {
            driver = new ChromeDriver(Config._Driverpath);
            js = (IJavaScriptExecutor)driver;
            actions = new Actions(driver);
            driver.Navigate().GoToUrl(Config._HomePageURL);
            driver.Manage().Window.Maximize();
            carlink = Helper.HelperFunctions.get_product_fromjson();

            // Creating the page instances 
            homepage = new HomePage(driver);
            loginpage = new LoginPage(driver);
            garagepage = new MyGaragePage(driver);
            searchpage = new SearchPage(driver);
            proddetailspage = new ProductDetailsPage(driver);


        }

        [Given(@"I am on the cargiant Home page")]
        public void GivenIAmOnTheCargiantHomePage()
        {
            Console.WriteLine(homepage.getTitle());
            Assert.IsTrue(homepage.getTitle().Contains(Config._HomePageTitle));
       }
        
        [When(@"I login with my user name and password")]
        public void WhenILoginWithMyUserNameAndPassword()
        {
            homepage.clickLoginPageLink();
            loginpage.DoLogin(Config._UserName, Config._Password);
        }

        [When(@"I search for products")]
        public void WhenISearchForProducts()
        {
            searchpage.GoToSearchPage();
        }

   
        [When(@"I choose to add a product")]
        public void WhenIChooseToAddAProduct()
        {
           searchpage.GoToProductDetailsPage();
           proddetailspage.addProduct();


        }

        [Then(@"the product should be there in my wishlist")]
        public void ThenTheProductShouldBeThereInMyWishlist()
        {
            garagepage.GoToMyGaragePage();
            Assert.IsTrue(garagepage.Garageentries().Contains(carlink));
          
        }

        [Then(@"I choose to delete the product")]
        public void ThenIChooseToDeleteTheProduct()
        {   
           garagepage.removecarfromwishlist();
        }

        [Then(@"the product should disappear from my wishlist")]
        public void ThenTheProductShouldDisappearFromMyWishlist()
        {
            garagepage.GoToMyGaragePage();
            Assert.IsFalse(garagepage.Garageentries().Contains(carlink));

        }



        [After]
        public void Teardown()
        {
           driver.Close();
           
       
        }
        
       
    }
}

