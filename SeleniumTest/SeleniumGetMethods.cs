using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest
{
    public static class SeleniumGetMethods
    {
        public static string GetText(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string GetTextFromDDL(this IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
            }
    }
}
