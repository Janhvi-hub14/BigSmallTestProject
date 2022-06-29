using BigSmallTestProject.Utilities;
using OpenQA.Selenium;
using System;

namespace BigSmallTestProject.CommonMethodObject
{
    public class BigSmallObject
    {
        // ...... Check  invalid  SignIn Function 

        public void SelectLoginPage()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement logIn = BaseClass.driver.FindElement(By.XPath("//span[text()='sign in']"));
            logIn.Click();

        }
        public void EmailId()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement password = BaseClass.driver.FindElement(By.XPath("//input[@id='CustomerEmail']"));
            password.SendKeys("janhvi@gmail.com");
        }
        public void Password()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement password = BaseClass.driver.FindElement(By.XPath("//input[@id='CustomerPassword']"));
            password.SendKeys("janhviAth");
        }
        public void SignInSuccessfully()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement signIn = BaseClass.driver.FindElement(By.XPath("//input[@type='submit']"));
            //signIn.Click();
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile("Text.png", ScreenshotImageFormat.Png);

        }
        public void Gotohome()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement gotohome = BaseClass.driver.FindElement(By.XPath("//img[@class='small--hide']"));
            //gotohome.Click();
        }


        //.....Add item to Wishlist
        public void ClickOnUniqueRakhi()
        {

            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement unique = BaseClass.driver.FindElement(By.XPath("//button[text()='Unique Rakhis']"));
            unique.Click();
        }
        public void ClickOnOneItem()

        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement item = BaseClass.driver.FindElement(By.XPath("//a[@href='/products/ludo-king-rakhi']"));
            item.Click();
        }

        public void ClickOnWishList()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement wishlist = BaseClass.driver.FindElement(By.XPath("//*[@id='ProductSection-4638094590040']/div/div/div[1]/div[2]/div/div[1]/div[1]/div/button"));
            wishlist.Click();
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile("Text.png", ScreenshotImageFormat.Png);
        }

        public void VerifyResult()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement result = BaseClass.driver.FindElement(By.XPath("//a[@href='#swym-wishlist']"));
            result.Click();
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile("Text.png", ScreenshotImageFormat.Png);
        }
        //.......TO fill Coporate deatils

        public void ClickCorporate()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement home = BaseClass.driver.FindElement(By.XPath("//*[@id='myheader']/div[1]/div/div/ul/li[4]/a"));
            home.Click();
        }
        public void Name()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement Name = BaseClass.driver.FindElement(By.Id("contactFormName"));
            Name.SendKeys("Sharavri Athnikar");
        }
        public void Email()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement Email = BaseClass.driver.FindElement(By.Id("contactFormEmail"));
            Email.SendKeys("Sharvariathnikar@gmail.com");
        }
        public void Phone()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement Phone = BaseClass.driver.FindElement(By.XPath("//*[@id='contactFormPhone']"));
            Phone.SendKeys("7028932765");
        }
        public void Enquiry()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement Enquiry = BaseClass.driver.FindElement(By.XPath("//*[@id='contactFormMessage']"));
            Enquiry.SendKeys("Marble is  available ?");
        }
        public void Submit()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement Submitbtn = BaseClass.driver.FindElement(By.XPath("//input[@type='submit'and @value='submit']"));
            Submitbtn.Click();
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile("CForm.png", ScreenshotImageFormat.Png);
        }

        //.......Add item to Add To Cart

        public void ClickNewProducts()
        {

            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement NewProducts = BaseClass.driver.FindElement(By.XPath("//button[text()='New Products']"));
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            NewProducts.Click();
        }
        public void ClickItem()

        {
          

            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement Clickimg = BaseClass.driver.FindElement(By.XPath("//a[@href='/products/tom-jerry-rug']"));
            Clickimg.Click();
        }

        public void ClickAddToCard()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
             IWebElement AddToCard = BaseClass.driver.FindElement(By.XPath("//button[@name='add']"));           
            AddToCard.Click();
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile("img.png", ScreenshotImageFormat.Png);
        }

        //......Check to Delivery is Your Pincode Or Not

        public void ClickOnGiftCard()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement GiftCard = BaseClass.driver.FindElement(By.XPath("//*[@id='myheader']/div[1]/header/div[2]/div[2]/div[4]/div/div/a[3]/i"));
            GiftCard.Click();
        }

        public void ClickOnPrice()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement ClickPrice = BaseClass.driver.FindElement(By.XPath("//label[@for='ProductSelect-738195636312-option-title-Rs.+1000']"));
            ClickPrice.Click();
        }

        public void EnterPincode()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement Pincode = BaseClass.driver.FindElement(By.XPath("//*[@id='PostalCode']"));
            Pincode.SendKeys("586101");
           

        }
        public void CheckPincode()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement Check = BaseClass.driver.FindElement(By.XPath("//*[@id='cod-cheker']/button"));
            Check.Click();
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile("Text.png", ScreenshotImageFormat.Png);
        }
    }
}
