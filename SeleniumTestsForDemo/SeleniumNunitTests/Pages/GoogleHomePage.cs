using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumNunitTests.Pages;
public class GoogleHomePage
{
    public string GetTitleHomePage(IWebDriver driver)
    {
        return driver.Title;
    }
}
