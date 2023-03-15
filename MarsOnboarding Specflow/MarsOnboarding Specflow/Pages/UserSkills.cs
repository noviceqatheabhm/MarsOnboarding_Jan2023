using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsOnboarding_Specflow.Utilities;

namespace MarsOnboarding_Specflow.Pages
{
    internal class UserSkills :CommonDriver
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        public IWebElement SkillButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        public IWebElement AddnewButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        public IWebElement AddskillTextbox => driver.FindElement(By.Name("name"));
        public IWebElement AddButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        public IWebElement SkillButton1 => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));

        public void CreateSkills(string Skills, string SkillLevel)
        {

            // Identify skill button and click and using explicit waits to locate elements
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")));
            SkillButton.Click();


            // Identify Add new button and click
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")));
            AddnewButton.Click();


            // Identify Add skill textbox and enter valid input
            AddskillTextbox.SendKeys(Skills);

            //selecting skll level 
            SelectElement SkilllevelDropdown = new SelectElement(driver.FindElement(By.Name("level")));
            SkilllevelDropdown.SelectByValue(SkillLevel);
            // Identify Add button and click
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")));
            AddButton.Click();

            // Identify skill button and click and using explicit waits to locate elements
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")));
            SkillButton1.Click();

        }


        public void CheckSkillAdded(string skill, string skillLevel)
        {


            //boolean value to check if the skill is added for assertion
            bool skillAdded = false;
            //reading all the columns from the table
            ReadOnlyCollection<IWebElement> elements;
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.TagName("td")));
            elements = driver.FindElements(By.TagName("td"));
            for (int i = 0; i < elements.Count; i++)
            {
                //checking to see if the value of skill is added to any column in the table
                if (elements[i].Text == skill)
                {
                    //true if skill present
                    skillAdded = true;
                    break;
                }
            }
            //fluent assertions. True if skill added
            skillAdded.Should().BeTrue();
        }
    }
}
