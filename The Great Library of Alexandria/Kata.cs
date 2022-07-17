using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Book_Of_Thoth.The_Great_Library_of_Alexandria
{
    internal class Kata
    {
        //Find Needle
        public static string FindNeedle(object[] haystack)
        {
            int index = Array.IndexOf(haystack, "needle");
            string result = "found the needle at position " + index;
            return result;
        }
        //Even Or Odd?
        public static string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
        //Is this my tail?
        public static bool CorrectTail(string body, string tail)
        {
            string sub = body.Substring(body.Length - (tail.Length));

            if (sub == tail)
                return true;
            else
                return false;
        }
        // Strip Comments
        public static string StripComments(string text, string[] commentSymbols)
        {

            string result = "";
            foreach (string symbol in commentSymbols)
            {
                string[] txt = text.Split("\n", StringSplitOptions.TrimEntries);
                foreach (string line in txt)
                {
                    int foundS1 = line.IndexOf(symbol);
                    if (foundS1 != -1)
                    {   
                        int count = line.Length - foundS1;
                        string nline = line.Remove(foundS1, count);
                        nline = nline.Trim();
                        result = result + nline + "\n";
                        
                    }
                    else
                    {

                       string nline = line.Trim();
                        result = result + nline + "\n";
                        
                    }
                    Console.WriteLine(result);
                }
                text = result;
            }
            Console.WriteLine(text);
            return text;
            //return Regex.Replace(text, delimiter + ".+", string.Empty).Trim();
        }
    }
}
