using System;
using System.Diagnostics;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World!";
            Console.WriteLine(StringUtil.FirstChar(s));
            Console.ReadKey();

        }
    }

    public static class StringUtil
    {
        // Extension
        public static string FirstChar(this string s)
        {
            Debug.Assert(s != null && s.Length > 1);
            return s[0].ToString();
        }
    }
}
