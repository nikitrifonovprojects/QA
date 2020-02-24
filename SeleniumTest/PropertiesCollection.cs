using OpenQA.Selenium;

namespace SeleniumTest
{
    public enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }

    public class PropertiesCollection
    {
        public static IWebDriver driver { get; set; }
    }
}
