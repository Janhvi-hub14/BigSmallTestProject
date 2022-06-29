using BigSmallTestProject.CommonMethodObject;
using System;
using TechTalk.SpecFlow;

namespace BigSmallTestProject.StepDefinationFile
{
    [Binding]
    public class BigSmallProjectSteps
    {
        BigSmallObject LogObj = new BigSmallObject();

        [Given(@"user is on the HomePage")]
        public void GivenUserIsOnTheHomePage()
        {
            //LogObj.Gotohome();
        }

        [Given(@"User Clicks on Gift card")]
        public void GivenUserClicksOnGiftCard()
        {
            LogObj.ClickOnGiftCard();
            Serilog.Log.Debug("User Clicks on Gift card");
        }
        
        [When(@"User On Login page")]
        public void WhenUserOnLoginPage()
        {
            LogObj.SelectLoginPage();
            Serilog.Log.Debug("User On Login page");
        }
        
        [When(@"User Enter Email Id")]
        public void WhenUserEnterEmailId()
        {
            LogObj.EmailId();
            Serilog.Log.Debug("User Enter Email Id");
        }
        
        [When(@"User Enter Password")]
        public void WhenUserEnterPassword()
        {
            LogObj.Password();
            Serilog.Log.Debug("User Enter Password");
        }
        
        [When(@"User Click on SignIn Button")]
        public void WhenUserClickOnSignInButton()
        {
            LogObj.SignInSuccessfully();
            Serilog.Log.Debug("User Click on SignIn Button");
        }
        
        [When(@"Go to Homepage")]
        public void WhenGoToHomepage()
        {
            LogObj.Gotohome();
            Serilog.Log.Debug("Go to Homepagen");
        }
        
        [When(@"User Clicks on price")]
        public void WhenUserClicksOnPrice()
        {
            LogObj.ClickOnPrice();
            Serilog.Log.Debug("User Clicks on price");
        }
    
        
        [When(@"User Enters PinCode")]
        public void WhenUserEntersPinCode()
        {
            LogObj.EnterPincode();
            Serilog.Log.Debug("User Enters PinCod");

        }
        
        [When(@"User Clicks on Check Button")]
        public void WhenUserClicksOnCheckButton()
        {
            LogObj.CheckPincode();
        }
        
        [When(@"click on unique rakhi")]
        public void WhenClickOnUniqueRakhi()
        {
            LogObj.ClickOnUniqueRakhi();
        }
        
        [When(@"click on item")]
        public void WhenClickOnItem()
        {
            LogObj.ClickOnOneItem();
        }
        
        [When(@"click add to wishlist button")]
        public void WhenClickAddToWishlistButton()
        {
            LogObj.ClickOnWishList();
        }
        
        [When(@"User click on Coproate")]
        public void WhenUserClickOnCoproate()
        {
            LogObj.ClickCorporate();
        }
        
        [When(@"User Enter Name")]
        public void WhenUserEnterName()
        {
            LogObj.Name();
        }
        
        [When(@"User Enter Email")]
        public void WhenUserEnterEmail()
        {
            LogObj.Email();
        }
        
        [When(@"User Enter Phone")]
        public void WhenUserEnterPhone()
        {
            LogObj.Email();
        }
        
        [When(@"User Fill Enquiry")]
        public void WhenUserFillEnquiry()
        {
            LogObj.Enquiry();
        }
        
        [When(@"click on NewProduct")]
        public void WhenClickOnNewProduct()
        {
            LogObj.ClickNewProducts();
            
        }
        
        [When(@"click on any one item")]
        public void WhenClickOnAnyOneItem()
        {
            LogObj.ClickItem();
        }
        
        [When(@"click add to cart button")]
        public void WhenClickAddToCartButton()
        {
            LogObj.ClickAddToCard();
        }
        
        [Then(@"User shoud able to Create Account Succesfully")]
        public void ThenUserShoudAbleToCreateAccountSuccesfully()
        {
            //LogObj.Gotohome();
        }
        
        [Then(@"User shoud able to Your Pincode Or Not Succesfully")]
        public void ThenUserShoudAbleToYourPincodeOrNotSuccesfully()
        {
            //LogObj.Gotohome();
        }

        [Then(@"item should be successfullly added in wishlist\.")]
        public void ThenItemShouldBeSuccessfulllyAddedInWishlist_()
        {
            //LogObj.Gotohome();
        }

        [Then(@"Click on submit")]
        public void ThenClickOnSubmit()
        {
            LogObj.Submit();
        }
        
        [Then(@"item should be successfullly added in Cart")]
        public void ThenItemShouldBeSuccessfulllyAddedInCart()
        {
            //LogObj.Gotohome();
        }
    }
}
