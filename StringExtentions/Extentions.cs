using System;

namespace StringExtentions
{
    public static class Extentions
    {
        /// <summary>
        /// Checks if the string is empty(null) or not
        /// </summary>
        /// <param name="value"></param>
        /// <param name="ignoreWhiteSpace"></param>
        /// <returns>bool</returns>
        public static bool HasValue(this string value, bool ignoreWhiteSpace = true)
        {
            return ignoreWhiteSpace ? !string.IsNullOrWhiteSpace(value) : !string.IsNullOrEmpty(value);
        }

        /// <summary>
        /// converts a string to int32
        /// </summary>
        /// <param name="value"></param>
        /// <returns>int32</returns>
        public static int StringToInt(this string value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>
        /// converts string to decimal
        /// </summary>
        /// <param name="value"></param>
        /// <returns>decimal</returns>
        public static decimal StringToDecimal(this string value)
        {
            return Convert.ToDecimal(value);
        }

        /// <summary>
        /// converts int to a string of numbers that are converted to a currency display format : 1,000,000
        /// </summary>
        /// <param name="value"></param>
        /// <returns>string</returns>
        public static string StringToNumeric(this int value)
        {
            return value.ToString("N0"); //"123,456"
        }

        /// <summary>
        /// converts decimal to a string of numbers that are converted to a currency display format : 1,000,000
        /// </summary>
        /// <param name="value"></param>
        /// <returns>string</returns>
        public static string StringToNumeric(this decimal value)
        {
            return value.ToString("N0");
        }

        /// <summary>
        /// int = 776889 to string = 776,889ریال
        /// </summary>
        /// <param name="value"></param>
        /// <returns>string</returns>
        public static string IntToCurrencyFormatString(this int value)
        {
            //fa-IR => current culture currency symbol => ریال
            //123456 => "123,123ریال"
            return value.ToString("C0");
        }

        /// <summary>
        /// decimal = 776889 to string = 776,889ریال
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DecimalToCurrencyFormatString(this decimal value)
        {
            return value.ToString("C0");
        }

        /// <summary>
        /// converts english numbers to arabic numbers
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string</returns>
        public static string EnNumbersToArabic(this string str)
        {
            return str.Replace("0", "۰")
                .Replace("1", "۱")
                .Replace("2", "۲")
                .Replace("3", "۳")
                .Replace("4", "۴")
                .Replace("5", "۵")
                .Replace("6", "۶")
                .Replace("7", "۷")
                .Replace("8", "۸")
                .Replace("9", "۹");
        }

        /// <summary>
        /// converts arabic numbers to english numbers
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string</returns>
        public static string ArabicToEn(this string str)
        {
            return str.Replace("۰", "0")
                .Replace("۱", "1")
                .Replace("۲", "2")
                .Replace("۳", "3")
                .Replace("۴", "4")
                .Replace("۵", "5")
                .Replace("۶", "6")
                .Replace("۷", "7")
                .Replace("۸", "8")
                .Replace("۹", "9")
                //iphone numeric
                .Replace("٠", "0")
                .Replace("١", "1")
                .Replace("٢", "2")
                .Replace("٣", "3")
                .Replace("٤", "4")
                .Replace("٥", "5")
                .Replace("٦", "6")
                .Replace("٧", "7")
                .Replace("٨", "8")
                .Replace("٩", "9");
        }

        /// <summary>
        /// switch between persian and arabian charachters
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string</returns>
        public static string FixPersianChars(this string str)
        {
            return str.Replace("ﮎ", "ک")
                .Replace("ﮏ", "ک")
                .Replace("ﮐ", "ک")
                .Replace("ﮑ", "ک")
                .Replace("ك", "ک")
                .Replace("ي", "ی")
                .Replace(" ", " ")
                .Replace("‌", " ")
                .Replace("ھ", "ه");//.Replace("ئ", "ی");
        }

        /// <summary>
        /// Removes all empty spaces in the string
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string</returns>
        public static string GetStringClean(this string str)
        {
            return str.Trim().FixPersianChars().ArabicToEn().NullIfEmpty();
        }

        /// <summary>
        /// Checks if null or whiteSpace returns null
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string or null</returns>
        public static string NullIfEmpty(this string str)
        {
            return str?.Length == 0 ? null : str;
        }

        /// <summary>
        /// Generates a unique identifier and converts it to a string, and the length of the string can also be specified
        /// </summary>
        /// <param name="numOfCharacter"></param>
        /// <returns>string</returns>
        public static string GenerateId(int numOfCharacter)
        {
            return Guid.NewGuid().ToString("N").Substring(0, numOfCharacter);
        }

        /// <summary>
        /// Generates a unique identifier and converts it to a string
        /// </summary>
        /// <returns>string</returns>
        public static string GenerateId()
        {
            return Guid.NewGuid().ToString("N");
        }

        /// <summary>
        /// Makes the string comparable
        /// </summary>
        /// <param name="text"></param>
        /// <returns>string</returns>
        public static string ComparableStrings(this string text)
        {
            string compareAble = text.TrimStart().TrimEnd().ToLower();
            return compareAble;
        }

        /// <summary>
        /// Combine an array of strings based on a character
        /// </summary>
        /// <param name="array"></param>
        /// <param name="character"></param>
        /// <returns>string</returns>
        public static string CombineWith(this string[] array, char character)
        {
            string newString = "";
            foreach (var item in array)
            {
                newString = string.IsNullOrWhiteSpace(newString) == true ? item : newString + character + item;
            }

            return newString;
        }
    }
}
