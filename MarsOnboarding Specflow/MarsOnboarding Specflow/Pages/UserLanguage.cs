using MarsOnboarding_Specflow.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;

namespace MarsOnboarding_Specflow.Pages
{
    public class UserLanguage :CommonDriver
    {

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        public IWebElement languagebutton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        public IWebElement addnewbutton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        public IWebElement addlanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
        public IWebElement addbutton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        public IWebElement languagebutton1 => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        public void CreateLanguages(string Language, string Level)
        {

            // Identify language button and click and using explicit waits to locate elements
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")));
            languagebutton.Click();
            // Identify Add new button and click
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")));
            addnewbutton.Click();
            // identifying add language tool box and enter values
            addlanguage.SendKeys(Language);
            // identifying choose language drop box
            SelectElement chooselanguage = new SelectElement(driver.FindElement(By.Name("level")));
            chooselanguage.SelectByValue(Level);

            // click add button
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")));
            addbutton.Click();

            // Identify language button and click and using explicit waits to locate elements
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")));
            languagebutton1.Click();

        }


        public void CheckLangugaeAdded(string Language, string Level)
        {

            //boolean value to check if the skill is added for assertion
            bool LanguageAdded = false;
            //reading all the columns from the table
            ReadOnlyCollection<IWebElement> elements;
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.TagName("td")));
            elements = driver.FindElements(By.TagName("td"));
            for (int i = 0; i < elements.Count; i++)
            {
                //checking to see if the value of skill is added to any column in the table
                if (elements[i].Text == Language)
                {
                    //true if language present
                    LanguageAdded = true;
                    break;
                }
            }
            //fluent assertions. True if skill added
            LanguageAdded.Should().BeTrue();
        }
    }

}  
    