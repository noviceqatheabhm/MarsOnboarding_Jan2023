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
    //3 initial trial automation testing
        //add language
    //    IWebElement addnewBox = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
    //        addnewBox.Click();

    //        IWebElement language = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
    //        language.SendKeys("English");
    //        IWebElement languageLevelDropdown = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
    //        languageLevelDropdown.Click();
    //        IWebElement languageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[5]"));
    //        languageLevel.Click();

    //        IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
    //        addButton.Click();

    //        Thread.Sleep(1000);

    //        IWebElement addCheck = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
    //        if (addCheck.Text == "English")
    //        {
    //            Console.WriteLine("New Language added successfully. Test passed");
    //        }
    //        else
    //        {
    //            Console.WriteLine("New Lanaguage is not added successfully. Test failed");
    //        }
    //    }

    //    public void UpdateLanguage(IWebDriver driver)
    //    {
    //        //update Language
    //        IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
    //        editButton.Click();

    //        IWebElement languageLevelDropdownBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
    //        languageLevelDropdownBox.Click();
    //        IWebElement languageDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select/option[4]"));
    //        languageDropdown.Click();

    //        IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
    //        updateButton.Click();

    //        Thread.Sleep(1000);
    //    }
    //    public void DeleteLanguage(IWebDriver driver)
    //    {
    //        //delete language
    //        IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
    //        deleteButton.Click();
    //    }

    //}

    //new code
    


  