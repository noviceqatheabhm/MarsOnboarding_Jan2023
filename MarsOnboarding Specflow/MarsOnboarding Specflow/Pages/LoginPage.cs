using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsOnboarding_Specflow.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            // enter the url
            driver.Navigate().GoToUrl("http://localhost:5000");

            //identify the sign in
            IWebElement signinTextbox = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signinTextbox.Click();


            //enter the login details - username and password
            IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            usernameTextbox.SendKeys("contactthevintagegirl@gmail.com");
            // username is contactthevintagegirl@gmail.com
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("P@ssword");
            //password is P@ssword

            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();

            Thread.Sleep(1000);
        }

    }
}
