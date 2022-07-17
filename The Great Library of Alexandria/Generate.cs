using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Of_Thoth.The_Great_Library_of_Alexandria
{
    internal class Generate
    {
        public static string NameToken()
        {
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string hour = DateTime.Now.ToString("hh_mm_ss");
            string code = Guid.NewGuid().ToString();
            code = code.Substring(0, 9);
            string token = date + "-" + code + hour;
            return token;
        }
        public static string Separator(string symbol)
        {
            string separator = symbol;
            do
            {
                separator += separator;
            } while (separator.Length < 63);
            separator += separator[..40];
            return separator;
        }
    }
}
