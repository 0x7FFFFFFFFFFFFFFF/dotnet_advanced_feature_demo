using System;
using System.Diagnostics;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World!";

            //We can call extention methods the normal way
            Console.WriteLine(StringUtil.FirstChar(s));

            //Or call it against the type being extended (string here)
            Console.WriteLine(s.FirstChar());

            //We can also pass parameters to extension methods
            Console.WriteLine(s.Chars(3));

            Console.ReadKey();

        }
    }

    
    //Extension methods enable you to add methods to existing types without creating a new derived type,
    //recompiling, or otherwise modifying the original type.

    //An extension method is a special kind of static method, but they 

    //An extension method is a static method of a static class, where the "this" modifier is applied to the
    //first parameter.The type of the first parameter will be the type that is extended. Extension methods
    //are called as if they were instance methods on the extended type.

    public static class StringUtil
    {
        public static string FirstChar(this string s)
        {
            Debug.Assert(s != null && s.Length > 1);
            return s[0].ToString();
        }

        public static string Chars(this string s, int n)
        {
            return s.Substring(0, n);
        }
    }
}
