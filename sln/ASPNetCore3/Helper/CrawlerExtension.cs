using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Helper
{
    public static class CrawlerExtension
    {
        public static string GetText(this IWebElement webElement)
        {
            return webElement == null ? string.Empty : webElement.Text;
        }

        public static float GetFloat(this IWebElement webElement, float defaultValue = 0)
        {
            return webElement.GetText().ToFloat(defaultValue);
        }

        public static long GetLong(this IWebElement webElement, long defaultValue = 0, NumberStyles numberStyles = NumberStyles.AllowThousands)
        {
            return webElement.GetText().ToLong(defaultValue, numberStyles);
        }
    }
}
