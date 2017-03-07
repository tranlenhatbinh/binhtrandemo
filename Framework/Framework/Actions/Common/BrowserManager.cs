﻿using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.Diagnostics;

namespace Framework.Actions.Common
{
    public class BrowserManager
    {
        public void OpenBrowser(string browsername)
        {
            switch(browsername.ToUpper())
            {
                case "FIREFOX":
                    Webdriver.driver = new FirefoxDriver();
                    Webdriver.driver.Manage().Window.Maximize();
                    break;
                case "CHROME":
                    Webdriver.driver = new ChromeDriver();
                    Webdriver.driver.Manage().Window.Maximize();
                    break;
                case "IE":
                    Webdriver.driver = new InternetExplorerDriver();
                    Webdriver.driver.Manage().Window.Maximize();
                    break;
                default:
                    Webdriver.driver = new FirefoxDriver();
                    Webdriver.driver.Manage().Window.Maximize();
                    break;
            }
        }

        public void CloseBrowser()
        {
            Webdriver.driver.Manage().Cookies.DeleteAllCookies();
            Webdriver.driver.Quit();
            foreach (Process process in Process.GetProcessesByName("iexplore"))
            {
                process.Kill();
            }
        }
    }
}
