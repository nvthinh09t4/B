using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Helper
{
    public static class ExtensionFunction
    {
        public static IWebElement TryFindElement(this IWebElement webElement, By by)
        {
            try
            {
                return webElement.FindElement(by);
            }
            catch (NoSuchElementException ex)
            {
                return null;
            }
        }
    }
}
