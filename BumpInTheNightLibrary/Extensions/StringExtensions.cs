using System;

namespace BumpInTheNightLibrary.Extensions
{
    public static class StringExtensions
    {
        public static string FormatWith(this string s, params object[] args)
        {
            return String.Format(s, args);
        }
    }
}