using MarsOnboarding_Specflow.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open the browser

static void Main(string[] args)
{
    IWebDriver driver = new ChromeDriver();

    //Initialize the login page
    LoginPage loginPageObj = new LoginPage();
    loginPageObj.LoginActions(driver);


    ProfileLanguage profileLanguageObj = new ProfileLanguage();
    profileLanguageObj.AddLanguage(driver);
    profileLanguageObj.UpdateLanguage(driver);
    profileLanguageObj.DeleteLanguage(driver);
}





//automation for 3 test cases
//add language


//how do we check if the language was successfully added?
//and edited
//and deleted
//create a specflow - create public classes and learn the pattern first





//English has been deleted from your languages