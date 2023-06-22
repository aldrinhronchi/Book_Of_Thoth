using System.Text.RegularExpressions;

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
            var lines = text.Split("\n");
            List<string> result = new List<string>();
            for (int i = 0; i < commentSymbols.Length; i++)
            {
                foreach (string line in lines)
                {
                    result.Add(Regex.Replace(line, "\\$" + commentSymbols[i] + ".+", string.Empty).Trim());
                }
            }
            return string.Join("\n", result);
            //return Regex.Replace(text, delimiter + ".+", string.Empty).Trim();
        }

        //Double Char
        public static string DoubleChar(string s)
        {
            // your code here
            char[] listChar = s.ToCharArray();
            string aux = "";
            foreach (char c in listChar)
            {
                aux = $"{aux}{c}{c}";
            }
            return aux;
        }

        //String repeat

        public static string RepeatStr(int n, string s)
        {
            string aux = "";
            for (int index = 0; n > index; index++)
            {
                aux = $"{aux}{s}";
            }
            return aux;
        }

        // Will there be enough space?
        public static int Enough(int cap, int on, int wait)
        {
            if (cap >= (wait + on))
            {
                return 0;
            }
            else
            {
                int dif;
                dif = wait - cap + on;

                return dif;
            }
        }

        //Keep up the hoop

        public static string HoopCount(int n)
        {
            //Your code goes here
            return n >= 10 ? "Great, now move on to tricks" : "Keep at it until you get it";
        }

        //Speed Control

        public static int Gps(int s, double[] x)
        {
            if (x.Length <= 1)
            {
                return 0;
            }

            double ratio = s / 3600f;

            double maxAvg = 0;
            double secStart = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                var secEnd = x[i];
                var speed = Math.Floor((secEnd - secStart) / ratio);
                if (speed > maxAvg)
                {
                    maxAvg = speed;
                }
                secStart = secEnd;
            }

            return (int)maxAvg;
        }

        // Sum Arrays
        public static double SumArray(double[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = array[i] + sum;
            }
            return sum;
        }

        // Find the smallest integer in the array
        public static int FindSmallestInt(int[] args)
        {
            int lil = args[0];
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] < lil)
                {
                    lil = args[i];
                }
            }
            return lil;
        }
    }
}