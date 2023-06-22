using Book_Of_Thoth.The_Great_Library_of_Alexandria;
using PokeApiNet;

namespace Book_Of_Thoth
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("O falso amor de si mesmo transforma a solidão em prisão. \n\t\t\t\t\t\tFriedrich Nietzsche");
            //'=================================================================================================================================================='
            //                                                          Variaveis
            //'=================================================================================================================================================='

            string separator = Generate.Separator("=");
            string localpath = @"C:\Users\Terore\Desktop\ConceptOne\Task\adjust rev bra";
            string Errors = "";
            string StackErrors = "";
            IDictionary<string, string[]> dicRevendas = new Dictionary<string, string[]>();
            string path = @"C:\Users\Terore\Desktop\ConceptOne\Task\Zenvia\html.txt";
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

            //DirectoryInfo dirInfo = new DirectoryInfo(localpath);

            //foreach (FileInfo file in dirInfo.GetFiles("*.xml"))
            //{
            //    try
            //    {
            //        XmlDocument xml = new XmlDocument();
            //        xml.PreserveWhitespace = true;
            //        xml.Load(file.FullName);

            //        XmlNamespaceManager xmlnsManager = new XmlNamespaceManager(xml.NameTable);
            //        xmlnsManager.AddNamespace("nfe", "http://www.portalfiscal.inf.br/nfe");

            //        XmlNodeList ChaveNota = xml.SelectNodes("//nfe:infNFe", xmlnsManager);
            //        if (ChaveNota.Count > 0)
            //        {
            //            XmlNode Chave = ChaveNota[0];
            //            Console.WriteLine($"{file.Name} | {Chave.Attributes["Id"].Value}");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        string exce = ex.Message;
            //        Console.WriteLine(exce);
            //    }
            //}
            // StripComments();
            string[] lines = File.ReadAllLines(path);
            String Modelo = "";

            foreach (var line in lines)
            {
                Modelo = $"{Modelo}\n{line}";
            }
            int indice = Modelo.IndexOf("[tabela]");
            Modelo = Modelo.Substring(indice, Modelo.Length - indice);
            Console.WriteLine(Modelo);
            //Pokemon emboar = GetPokemon("Emboar");
            //Dictionary<Int32, Pokemon> pokeList = new Dictionary<int, Pokemon>();
            //for (int index = 1; 152 > index; index++)
            //{
            //    Pokemon pokemon = GetPokemon(index.ToString());
            //    pokeList.Add(index, pokemon);
            //}
            //foreach (KeyValuePair<int, Pokemon> pokePar in pokeList)
            //{
            //    Console.WriteLine($"Pokemon number: {pokePar.Key} is {pokePar.Value.Name}");
            //}

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

        private static void Edge(string separator, string color, string msg)
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

        private static void StripComments()
        {
            Console.WriteLine();
            if ((
                    "apples, pears\ngrapes\nbananas" ==
                    Kata.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" })))
            { Console.WriteLine("Pass"); }

            if (("a\nc\nd" == Kata.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" })))
            { Console.WriteLine("Pass"); }
        }

        private static async Task<Pokemon> GetPokemonAsync(String name)
        {
            Pokemon pokemon = null;
            PokeApiClient pokeClient = new PokeApiClient();
            if (Int32.TryParse(name, out int number))
            {
                pokemon = await pokeClient.GetResourceAsync<Pokemon>(number);
            }
            else
            {
                pokemon = await pokeClient.GetResourceAsync<Pokemon>(name);
            }
            // get a resource by name
            return pokemon;
        }

        private static Pokemon GetPokemon(String name)
        {
            Pokemon pokemon = null;
            Task<Pokemon> pokemonTask = GetPokemonAsync(name);
            pokemon = pokemonTask.Result;
            return pokemon;
        }
    }
}