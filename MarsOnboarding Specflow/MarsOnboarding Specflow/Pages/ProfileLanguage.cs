using OpenQA.Selenium;


namespace MarsOnboarding_Specflow.Pages
{
    public class ProfileLanguage
    {
        public void AddLanguage(IWebDriver driver)
        {
            //3 automation testing
            //add language
            IWebElement addnewBox = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewBox.Click();

            IWebElement language = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            language.SendKeys("English");
            IWebElement languageLevelDropdown = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            languageLevelDropdown.Click();
            IWebElement languageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[5]"));
            languageLevel.Click();

            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();

            Thread.Sleep(1000);

            IWebElement addCheck = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            if (addCheck.Text == "English")
            {
                Console.WriteLine("New Language added successfully. Test passed");
            }
            else
            {
                Console.WriteLine("New Lanaguage is not added successfully. Test failed");
            }
        }

        public void UpdateLanguage(IWebDriver driver) 
        {
            //update Language
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editButton.Click();

            IWebElement languageLevelDropdownBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            languageLevelDropdownBox.Click();
            IWebElement languageDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select/option[4]"));
            languageDropdown.Click();

            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            updateButton.Click();

            Thread.Sleep(1000);
        }
        public void DeleteLanguage(IWebDriver driver) 
        {
            //delete language
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deleteButton.Click();
        }
        
    }
}
