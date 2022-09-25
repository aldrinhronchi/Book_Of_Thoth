using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Of_Thoth.The_Great_Library_of_Alexandria
{
    internal class Alter
    {
        public List<string> Limpar(List<string> lst)
        {
           return lst.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .ToList();

        }
    }
}
