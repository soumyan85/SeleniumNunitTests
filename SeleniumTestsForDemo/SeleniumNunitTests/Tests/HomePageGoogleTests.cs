using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumNunitTests.Pages;

namespace SeleniumNunitTests.Tests

{
    public class HomePageGoogleTests
    {
        private IWebDriver driver;
        private GoogleHomePage googlePage;

        [OneTimeSetUp]
        public void Setup()
        {
            // Initialize Chrome browser
            driver = new ChromeDriver();
            googlePage = new GoogleHomePage();
        }

        [Test]
        public void ValidateGoogleHomePageTitle()
        {
            
            // Navigate to Google
            driver.Navigate().GoToUrl("https://www.google.com");

            // Assert the title
            string? title = googlePage.GetTitleHomePage(driver);
            Assert.That(title, Is.EqualTo("Google"));
        }

        [Test]
        public void ValidateTextAboutLanguage()
        {
            var languageText = driver.FindElement(By.Id("SIvCob")).Text;
            Assert.That(languageText, Does.Contain("Google"));
        }

        [OneTimeTearDown]
        public void Teardown()
        {
            // Close the browser
            driver.Quit();
            driver.Dispose();
        }
    }
}