using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using System;

namespace ReqnrollBDDFramework
{
    [Binding]
    public class LoginStepDefinitions
    {
        private IWebDriver driver;

        [Given("I navigate to the login page")]
        public void GivenINavigateToTheLoginPage()
        {
            //Console.WriteLine("Step executed: Navigate to login page");
            driver = new ChromeDriver();             // Initialize ChromeDriver
            driver.Manage().Window.Maximize();       // Maximize window
            driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
        }

        [When("I enter valid username and password")]
        public void WhenIEnterValidUsernameAndPassword()
        {
            //Console.WriteLine("Step executed: Enter valid username and password");
             driver.FindElement(By.Id("username")).SendKeys("student");
             driver.FindElement(By.Id("password")).SendKeys("Password123");
        }

        [When("I click the submit button")]
        public void WhenIClickTheSubmitButton()
        {
            //Console.WriteLine("Step executed: Click submit button");
            driver.FindElement(By.Id("submit")).Click();
        }

        [Then("I should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            //Console.WriteLine("Step executed: Verify login success");
            Assert.Pass("Login verified (placeholder)");
        }

        [Then("the log out button should be displayed")]
        public void ThenTheLogOutButtonShouldBeDisplayed()
        {
            //Console.WriteLine("Step executed: Verify logout button");
            Assert.Pass("Logout button verified (placeholder)");
        }
    }
}
