using Book_Of_Thoth.Work;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;       //microsoft Excel 14 object in references-> COM tab


namespace Book_Of_Thoth.The_Great_Library_of_Alexandria
{
    internal class Read
    {
        public static void FolderItems(string local)
        {
            IDictionary<string, string[]> dic1 = new Dictionary<string, string[]>();

            if (Directory.Exists(local))
            {
                string[] subpastas = Directory.GetDirectories(local);
                foreach (string nomePastas in subpastas)
                {
                    var nome = new DirectoryInfo(nomePastas).Name;
                    Console.WriteLine(nome);
                    string[] fileEntries = Directory.GetFiles(nomePastas);
                    foreach (var fileName in fileEntries)
                    {

                        Console.WriteLine(fileName);
                    }
                    dic1.Add(nomePastas, fileEntries);
                }
            }

            foreach (KeyValuePair<string, string[]> item in dic1)
            {
                foreach (string valor in item.Value)
                {
                   
                    Console.WriteLine("chave: {0}, \n\t\t valor: {1}", item.Key, valor);

                }
            }
        }
        public static void Xlsx(string local, string file)
        {
            string fullpath = local + file;
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fullpath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    //new line
                    if (j == 1)
                        Console.Write("\r\n");

                    //write the value to the console
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");
                }
            }
            /*
            // 30
            // linha, coluna
            Excel.Range rng = xlRange.Cells[1, 57];
            string valor = rng.Value2.ToString();
            Console.WriteLine(valor);
            */

        }

       public static void CNABReader(Int32 tipo)
        {
            string localpath = @"D:\work\xmlcompress\Book_Of_Thoth\Book_Of_Thoth\Upload\";
           
            foreach (var file in Directory.GetFiles(@"C:\Users\Terore\Downloads\ANEXOS_EMAIL\CNAB", "*.*", SearchOption.AllDirectories))
            {
                switch (tipo)
                {
                    case 500:
                        #region CNAB500
                        List<CNAB> desemborso = new List<CNAB>();
                        string[]? a = File.ReadAllLines(file);
                        List<String> arq = new List<String>(a);
                        string codcedente = arq[0].Substring(35, 11);
                        arq.RemoveRange(0, 1);
                        arq.RemoveRange(arq.Count - 1, 1);

                        foreach (string line in arq)
                        {
                            CNAB cnab = new CNAB();
                            cnab.lastro = line.Substring(47, 16);
                            cnab.valor = line.Substring(228, 13);
                            cnab.forn = line.Substring(407, 40);
                            cnab.CodCedente = codcedente;
                            Console.WriteLine(cnab.lastro);
                            Console.WriteLine(cnab.valor);
                            Console.WriteLine(cnab.forn);
                            Console.WriteLine(cnab.CodCedente);
                            desemborso.Add(cnab);
                        }
                        using (var writer = new StreamWriter($"{localpath}/desembolsos.csv"))
                        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                        {
                            csv.WriteRecords(desemborso);
                        }
                        #endregion CNAB500
                        break;
                    default:
                       
                        throw new Exception($"Nao Implementado");
                }




            }
           
        }
    }
}
