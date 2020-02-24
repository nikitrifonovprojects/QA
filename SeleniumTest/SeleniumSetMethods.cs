using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest
{
    public static class SeleniumSetMethods
    {
        //Extended method for entering text in the control
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //Extended method for Click button, checkbox
        public static void Clicks(this IWebElement element)
        {
            element.Submit();
        }

        //Extended method for Selecting dropdown control
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
