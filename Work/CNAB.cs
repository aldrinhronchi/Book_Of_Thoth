using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Of_Thoth.Work
{
    public class CNAB
    {
        [Name("Lastro")]
        public string lastro { get; set; }
        [Name("Valor")]
        public string valor { get; set; }
        [Name("Nome")]
        public string forn { get; set; }
        [Name("CodCedente")]
        public string CodCedente { get; set; }

    }
}
