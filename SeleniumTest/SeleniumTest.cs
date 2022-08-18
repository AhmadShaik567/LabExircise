using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace LABEXIRCISE
{
    [TestClass]
    public class SeleniumTest
    {

        
        
        [DataTestMethod]
        [Ignore]
        [DataRow("Firefox","https://www.demoblaze.com/")]
        [DataRow("Chrome","https://www.demoblaze.com/")]
        [DataRow("Edge","https://www.demoblaze.com/")]
       
        
        public void TestDataMethod1(string browser,string url)
        
        {
         IWebDriver driver;
         if(browser == "Firefox")
        
    
        {
        driver = new FirefoxDriver(@"C:\ROOTFOLDER\WEBDRIVER");
         
        }else if(browser== "Chrome")

        {
        driver = new ChromeDriver(@"C:\ROOTFOLDER\WEBDRIVER");
         
        }else 

        {
        driver = new EdgeDriver(@"C:\ROOTFOLDER\WEBDRIVER");
         
        }

        driver.Navigate().GoToUrl(url);
        IWebElement Contact= driver.FindElement(By.LinkText("Contact"));
        Contact.Click();
        Thread.Sleep(2000);

        IWebElement Email= driver.FindElement(By.Id("recipient-name"));
        Email.SendKeys("sig@gmail.com");
        Thread.Sleep(2000);

        IWebElement Message= driver.FindElement(By.Id("message-text"));
        Message.SendKeys("Hi Every One");
        Thread.Sleep(2000);


        driver.Quit();
        }   
         
        
        [DataTestMethod]
        [DataRow("Firefox","https://www.demoblaze.com/","ahmad@gmail.com","Ahmad","I am a Tester")]
        [DataRow("Chrome","https://www.demoblaze.com/","afrid@gmail.com","Afrid","I am Student")]
        [DataRow("Edge","https://www.demoblaze.com/","Aashiq@gmail.com","Aashiq","I am Rocker")]
       
        
        public void TestDataMethod2(string browser,string url,string email,string name,string message)
        
        {
         IWebDriver driver;
         if(browser == "Firefox")
        {
        driver = new FirefoxDriver(@"C:\ROOTFOLDER\WEBDRIVER");
        }else if(browser == "Chrome")

        {
        driver = new ChromeDriver(@"C:\ROOTFOLDER\WEBDRIVER");
         
        }else
        
        {
        driver = new EdgeDriver(@"C:\ROOTFOLDER\WEBDRIVER");
         
        }
        
        driver.Navigate().GoToUrl(url);
        IWebElement Contact= driver.FindElement(By.LinkText("Contact"));
        Contact.Click();
        Thread.Sleep(2000);

        IWebElement Email= driver.FindElement(By.Id("recipient-email"));
        Email.SendKeys(email);
        Thread.Sleep(2000);

        IWebElement Name= driver.FindElement(By.Id("recipient-name"));
        Name.SendKeys(name);
        Thread.Sleep(2000);

        IWebElement Message= driver.FindElement(By.Id("message-text"));
        Message.SendKeys(message);
        Thread.Sleep(2000);

        IWebElement Close= driver.FindElement(By.XPath("
//button[@onclick='send']/preceding-sibling::button[@type='button']"));
        Close.Click();


        driver.Quit();
        }

    }
 }



