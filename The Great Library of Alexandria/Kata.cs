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

        public static int Gps(int s, double[] x)
        {
            // your code
            if (x.Length <= 1)
            {
                return 0;
            }

            double[] output = new double[1000];
            for (int index = 0; index < x.Length; index++)
            {
                output[index] = (x[index + 1] - x[index]) * 3600 / s;
            }

            return (int)output.Max();
        }
    }
}