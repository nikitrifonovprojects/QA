using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();

            //Navigate to page
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/Login.html");

            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            ExcelLib.PopulateInCollection(@"C:\Users\Nikki\Desktop\Niki Programming\SeleniumTest\Data.xlsx");


            //Login to application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login(ExcelLib.ReadData(1, "UserName"), ExcelLib.ReadData(1, "Password"));

            pageEA.FillUserForm(ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "MiddleName"), ExcelLib.ReadData(1, "FirstName"));


            ////Title
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            ////Initial
            //SeleniumSetMethods.EnterText("Initial", "execute", PropertyType.Name);

            //Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id));

            //Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            ////Click
            //SeleniumSetMethods.Click("Save", PropertyType.Name);

        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();

            Console.WriteLine("Close the browser");
        }
    }
}
