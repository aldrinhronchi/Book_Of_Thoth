using Book_Of_Thoth.The_Great_Library_of_Alexandria;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Of_Thoth.Work
{
    internal class SkeletonAbe
    {
        void Main() 
        {
            string Errors = "";
            string StackErrors = "";
            IDictionary<string, string[]> dicRevendas = new Dictionary<string, string[]>();
            string localpath = @"D:\work\xmlcompress\Book_Of_Thoth\Upload\";
            string localtempPath = $"{localpath}/testeFidcRevenda/Xml/";
            string localzipPath = $"{localpath}/testeFidcRevenda/Zip/";
            string localexcelPath = $"{localpath}/testeFidcRevenda/Excel/";
            string nomearquivo = "";
            try
            {
                //Thread.Sleep(9000);

                Errors = "";
                int processo = 001; //fazer função pegar processo
                nomearquivo = processo.ToString() + "-" + Generate.NameToken();
                string zipPath = localzipPath + nomearquivo + ".zip";
                string Erro = "DUPLICADO";
                // Read.FolderItems(@"D:\work\afort\GestaoOperacoes\Upload\testeFidcRevenda\");
                //Console.WriteLine(nomearquivo);
                localtempPath = @"D:\work\afort\GestaoOperacoes\Upload\testeFidcRevenda\XML";
                int quantidade = 0;
                string[] files = Directory.GetFiles(localtempPath, "*.xml");


                // zip.Dispose();
                // Validar(quantidade);
                /*
                    if (Validar(localtempPath, quantidade))
                {
                    // salvar o excel no ft
                    string excelfile = localexcelPath + codigo + ".xls";
                    using (FidcSFTP sftp = new FidcSFTP())
                    {
                        FileStream Excel = File.OpenRead(excelfile);
                        DadosExcel excel = new DadosExcel()
                        {
                            Data = DateTime.Now,
                            Caminho = excelfile,
                            Processo = processo,
                        };
            
                        sftp.UploadProcessed(Excel, codigo + ".xls");
                        //upa no banco
                        using (AfortContext db = new AfortContext())
                        {   
                            db.FidcRevenda_DadosExcel.Add(excel);
                            db.SaveChanges();
                        }
                    }
                }
                */
                Console.WriteLine("Done!");
            }
            catch (Exception e)
            {
                Errors = e.Message + "\n";
                StackErrors = e.StackTrace;
            }
            //Estado = "Aguardando";
        }
        void Skelethor() {
            //Entra no FTP
            //Baixa os Arquivos do FTP
            //Salva no Local
            //Exclui do FTP
            /*
             using (FidcSFTP sftp = new FidcSFTP())
             {
                 var filesFTP = sftp.GetFolderFiles();
                 if (filesFTP != null)
                 {
                     foreach (var file in filesFTP)
                      {
                                    //FarmGerenciadorDeProcessoDeArquivos.AdicionarArquivo(file);
                        FidcRevendaGerenciadorDeProcessoDeArquivos.AdicionarArquivo(file, processo);
                      }
                  }
              }
             */
            //Verifica se é xml
            /*
            if (!Arquivo.NomeFTP.ToLower().EndsWith(".xml"))
            {
                string newfilename = AlteraNome(arquivo.NomeFTP, processo, "Extensao")
                 using (FileStream fileUp = new FileStream(FilePath, FileMode.Open))
                { 
                    sftp.UploadError(fileUp, Arquivo.NomeFTP);
                } 
            }*/
        //Comprime
        /*
        var zip = ZipFile.Open(@"D:\work\afort\GestaoOperacoes\Upload\testeFidcRevenda\ZIP\", ZipArchiveMode.Create);
        string localtempPath = @"D:\work\afort\GestaoOperacoes\Upload\testeFidcRevenda\XML\";
        int quantidade = 0;
        string[] files = Directory.GetFiles(localtempPath, "*.xml");
        foreach (var file in files)
        {
            // Add the entry for each file
            zip.CreateEntryFromFile(file, Path.GetFileName(file), CompressionLevel.Optimal);
            quantidade =+ 1;
        }
        zip.Dispose();
        */
            //Passa para validar

            //Verifica o CNPJ do Fornecedor com o BD

            //Se validou 001 senao 998

            //Adiciona o Excel no local

            //Salva o Excel no FTP
        }
        public static string AlteraNome(string arquivo, string processo, string metodo)
        {
            string date = DateTime.Now.ToString("ddMMyyyy");
            string nfile = arquivo.Split(@"\").Last();
            if (metodo == "")
            {
                return processo + "-" + date + "-" + nfile;
            }
            else
            {
                return metodo.ToUpper() + "-" + processo + "-" + date + "-" + nfile;
            }
        }


    }
}
