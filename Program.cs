using Book_Of_Thoth.Work;
using Book_Of_Thoth.The_Great_Library_of_Alexandria;
using System;
using System.Xml;
using CsvHelper;
using System.Globalization;

namespace Book_Of_Thoth
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("O falso amor de si mesmo transforma a solidão em prisão. \n\t\t\t\t\t\tFriedrich Nietzsche");
            //'=================================================================================================================================================='
            //                                                          Variaveis
            //'=================================================================================================================================================='
           
            string separator = Generate.Separator("=");
            string localpath = @"C:\Users\Terore\Desktop\ConceptOne\Task\FIDCRevenda\Tests\XML\10102022";
            string Errors = "";
            string StackErrors = "";
            IDictionary<string, string[]> dicRevendas = new Dictionary<string, string[]>();
            string path = @"D:\codes\Book-of-Thoth\Book_Of_Thoth\Upload\";
            string localtempPath = $"{localpath}/XML/";
            string localzipPath = $"{localpath}/Zip/";
            string localexcelPath = $"{localpath}/Excel/";
            string nomearquivo = "";

            //'=================================================================================================================================================='
            //                                                         Metodos
            //'=================================================================================================================================================='
            //'--------------------------------------------------------------------------------------------------------------------------------------------------'
            //                                                          Cabeçalho
            //-'-------------------------------------------------------------------------------------------------------------------------------------------------'
            Edge(separator, "Green", "I am Running!");
            //'--------------------------------------------------------------------------------------------------------------------------------------------------'

            String s = "suruba";
            List<char> listChar = s.ToCharArray().ToList();

            //var a = File.ReadAllLines(@"C:\Users\Terore\Desktop\ConceptOne\Task\CORTEVA CNAB ERROR\allregisters.txt");
            //var notfound = a.Distinct().ToList();
            //foreach (var b in notfound)
            //{
            //    Console.WriteLine(b);
            //}
            //string Word = "92660604000182";
            //string Word2 = "18337224000159";
            //string Word3 = "5197599000119";

            //string nfe = "TANP00054/2022";
            //nfe = new String(nfe.Where(Char.IsDigit).ToArray());
            //Console.WriteLine(nfe);
            //DirectoryInfo dirInfo = new DirectoryInfo(localtempPath);
            /*  foreach (FileInfo file in dirInfo.GetFiles("*.xml"))
              {
                  //NotaFiscal nota = new NotaFiscal();

                  XmlDocument xml = new XmlDocument();
                  xml.PreserveWhitespace = true;



                  try
                  {
                      xml.Load(file.FullName);
                  }
                  catch (Exception e)
                  {
                      Console.WriteLine(e.Message);
                  }

                  XmlNamespaceManager xmlnsManager = new XmlNamespaceManager(xml.NameTable);
                  xmlnsManager.AddNamespace("nfe", "http://www.portalfiscal.inf.br/nfe");

                  XmlNodeList CNPJDevedor = xml.SelectNodes("//nfe:dest/nfe:CNPJ", xmlnsManager);
                  if (CNPJDevedor.Count > 0)
                  {
                      XmlNode Cnpj = CNPJDevedor[0];
                      Console.WriteLine(Cnpj.InnerText);
                  }

                  XmlNodeList NomeDevedor = xml.SelectNodes("//nfe:dest/nfe:xNome", xmlnsManager);
                  if (NomeDevedor.Count > 0)
                  {
                      XmlNode Nome = NomeDevedor[0];
                      Console.WriteLine(Nome.InnerText);
                  }

              }
             *//*
            foreach (FileInfo file in dirInfo.GetFiles("*.xml"))
            {
                string date = DateTime.Now.ToString("ddMMyyyy");
                string nfile = file.Name;
                string metodo = "Erro";
                string processo = "001";
                if (metodo == "")
                {
                    nfile = processo + "-" + date + "-" + nfile;
                }
                else
                {
                    nfile = metodo.ToUpper() + "-" + processo + "-" + date + "-" + nfile;
                }
                Console.WriteLine(nfile);
            }
            */
            //'--------------------------------------------------------------------------------------------------------------------------------------------------'
            //                                                      Rodape
            //'--------------------------------------------------------------------------------------------------------------------------------------------------'

            Edge(separator, "Blue", "And done!");
                //'-------------------------------------------------------------------------------------------------------------------------------------------------'
            }


            static void Edge(string separator, string color, string msg)
            {
                if (Enum.TryParse(color, out ConsoleColor foreground))
                {
                    Console.ForegroundColor = foreground;
                }
                Console.WriteLine(separator);
                Console.SetCursorPosition((Console.WindowWidth - msg.Length - 10) / 2, Console.CursorTop);
                Console.WriteLine(msg);
                Console.WriteLine(separator);
                Console.ForegroundColor = ConsoleColor.White;
            }
            static void StripComments()
            {

                Console.WriteLine();
                if ((
                        "apples, pears\ngrapes\nbananas" ==
                        Kata.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" })))
                { Console.WriteLine("Pass"); }

                if (("a\nc\nd" == Kata.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" })))
                { Console.WriteLine("Pass"); }

            }
           
        
        
    }
    }
