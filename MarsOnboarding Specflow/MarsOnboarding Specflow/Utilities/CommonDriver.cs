using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarsOnboarding_Specflow.Utilities
{
    [Binding]
    public class CommonDriver
    {
        public static IWebDriver driver;



        //Base Url
        public static string Url = "http://localhost:5000";

        [AfterScenario]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
    
}
