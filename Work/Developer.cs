using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace Book_Of_Thoth.Work
{ 
    public class Developer
{
    public static Models.Developer GetDev(Int32 ID = 0)
    {
        Models.Developer dev = new Models.Developer();
        if (ID == 0)
        {
            String id = WebConfigurationManager.AppSettings.AllKeys.Contains("Developer") ? WebConfigurationManager.AppSettings["Developer"] : "1";
            ID = Int32.Parse(id);
        }
        using (AfortContext db = new AfortContext())
        {
            dev = db.Developer.Where(x => x.ID == ID && x.Ativo == true).FirstOrDefault();
        }
        return dev;
    }

    public static String EmailForDev(Int32 ID = 0)
    {
        if (ID == 0)
        {
            String id = WebConfigurationManager.AppSettings.AllKeys.Contains("Developer") ? WebConfigurationManager.AppSettings["Developer"] : "1";
            ID = Int32.Parse(id);
        }
        Models.Developer dev = GetDev(ID);
        String email = dev.Email;
        return email;
    }

    public static String EmailLog()
    {
        String email = EmailForDev(1);
        return email;
    }

    public static String GetPPK()
    {
        Models.Developer dev = GetDev();
        String caminhoppk = dev.CaminhoPPK;
        return caminhoppk;
    }

    public static String GetCoringa(Int32 campo, Int32 ID = 0)
    {
        String valor = null;
        Models.Developer dev = GetDev(ID);

        switch (campo)
        {
            case 1:
                valor = dev.CampoCoringa1;
                break;

            case 2:
                valor = dev.CampoCoringa2;
                break;

            case 3:
                valor = dev.CampoCoringa3;
                break;

            case 4:
                valor = dev.CampoCoringa4;
                break;

            case 5:
                valor = dev.CampoCoringa5;
                break;

            case 6:
                valor = dev.CampoCoringa6;
                break;

            case 7:
                valor = dev.CampoCoringa7;
                break;

            case 8:
                valor = dev.CampoCoringa8;
                break;

            case 9:
                valor = dev.CampoCoringa9;
                break;
        }

        return valor;
    }

    public static Boolean SetCoringa(Int32 campo, String valor, Int32 ID = 0)
    {
        Models.Developer dev = GetDev(ID);
        try
        {
            //using (AfortContext db = new AfortContext())
            //{
                switch (campo)
                {
                    case 1:
                        dev.CampoCoringa1 = valor;
                        break;

                    case 2:
                        dev.CampoCoringa2 = valor;
                        break;

                    case 3:
                        dev.CampoCoringa3 = valor;
                        break;

                    case 4:
                        dev.CampoCoringa4 = valor;
                        break;

                    case 5:
                        dev.CampoCoringa5 = valor;
                        break;

                    case 6:
                        dev.CampoCoringa6 = valor;
                        break;

                    case 7:
                        dev.CampoCoringa7 = valor;
                        break;

                    case 8:
                        dev.CampoCoringa8 = valor;
                        break;

                    case 9:
                        dev.CampoCoringa9 = valor;
                        break;
                }
            //    db.SaveChanges();
            //}
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    internal static dynamic InternalSFTP(String Ambiente, String Processo, bool Manter, String Extensao)
    {
        String PathSFTP = $"{HostingEnvironment.ApplicationPhysicalPath}/Upload/InternalSFTP/";
        String PathEstoque = $"{HostingEnvironment.ApplicationPhysicalPath}/Upload/";
        String FileName = "";
        string[] files;
        switch (Ambiente)
        {
            case "CORTEVA":
                #region CORTEVA
                PathSFTP = $"{PathSFTP}/CORTEVA/";
                switch (Processo)
                {
                    case "Desembolso":
                        PathSFTP = $"{PathSFTP}DESEMBOLOS";
                        break;
                    case "Formalizacao":
                        PathSFTP = $"{PathSFTP}Formalizacao";
                        break;
                }

                PathEstoque = $"{PathEstoque}/EstoqueFarm/";

                files = Directory.GetFiles(PathSFTP, $"*.{Extensao.ToLower()}");

                foreach (var file in files)
                {
                    FileName = file.Split(Path.DirectorySeparatorChar).Last();
                    System.IO.File.Copy(file, $"{PathEstoque}/{FileName}", true);
                }
                if (FileName == "")
                {
                    throw new Exception($"Sem arquivo no SFTP Interno, insira por favor");
                }
                /* REGISTRO DO BANCO
                EstoqueArquivo Arquivo = new EstoqueArquivo()
                {
                    Nome = FileName,
                    NomeFTP = FileName,
                    Data = DateTime.Now,
                    Status = "Baixado"
                };

                using (AfortContext db = new AfortContext())
                {
                    db.EstoqueArquivo.Add(Arquivo);
                    db.SaveChanges();
                }
                */
                if (!Manter)
                {
                    System.IO.File.Delete($"{PathSFTP}/{FileName}");
                }
                //return Arquivo;
                return null;

                break;
            #endregion
            case "YARA":
                #region YARA
                PathSFTP = $"{PathSFTP}/YARA/";
                switch (Processo)
                {
                    case "Desembolso":
                        PathSFTP = $"{PathSFTP}DESEMBOLOS";
                        break;
                    case "Formalizacao":
                        PathSFTP = $"{PathSFTP}Formalizacao";
                        break;
                }

                PathEstoque = $"{PathEstoque}/EstoqueYara/";

                files = Directory.GetFiles(PathSFTP, $"*.{Extensao.ToLower()}");

                foreach (var file in files)
                {
                    FileName = file.Split(Path.DirectorySeparatorChar).Last();
                    System.IO.File.Copy(file, $"{PathEstoque}/{FileName}", true);
                }
                if (FileName == "")
                {
                    throw new Exception($"Sem arquivo no SFTP Interno, insira por favor");
                }
                /* REGISTRO DO BANCO
                EstoqueArquivoYara ArquivoYara = new EstoqueArquivoYara()
                {
                    Nome = FileName,
                    NomeFTP = FileName,
                    Data = DateTime.Now,
                    Status = "Baixado"
                };

                using (AfortContext db = new AfortContext())
                {
                    db.EstoqueArquivoYara.Add(ArquivoYara);
                    db.SaveChanges();
                }
                */
                if (!Manter)
                {
                    System.IO.File.Delete($"{PathSFTP}/{FileName}");
                }
                //return ArquivoYara;
                return null ;

                break;
            #endregion
            case "SUMITOMO":
                throw new NotImplementedException();
                break;
            case "REVENDA":
                #region REVENDA
                PathSFTP = $"{PathSFTP}/REVENDAS/";
                switch (Processo)
                {
                    case "Desembolso":
                        PathSFTP = $"{PathSFTP}Desembolos";
                        PathEstoque = $"{PathEstoque}/EstoqueFidc/";
                        break;
                    case "Formalizacao":
                        PathSFTP = $"{PathSFTP}Formalizacao";
                        PathEstoque = $"{PathEstoque}/testeFidcRevenda/Xml/";
                        break;
                }


                files = Directory.GetFiles(PathSFTP, $"*.{Extensao.ToLower()}");

                foreach (string file in files)
                {
                    FileName = file.Split(Path.DirectorySeparatorChar).Last();
                    System.IO.File.Copy(file, $"{PathEstoque}/{FileName}", true);
                }
                if (FileName == "")
                {
                    throw new Exception($"Sem arquivo no SFTP Interno, insira por favor");
                }

                if (!Manter)
                {
                    System.IO.File.Delete($"{PathSFTP}/{FileName}");
                }
                return true;

                break;
            #endregion
            default:
                throw new Exception("Nome incorreto ou nao implementado");
                break;
        }

        throw new NotImplementedException();

    }


    public static List<String> GetRobots(Int32 ID = 0)
    {
        Models.Developer dev = GetDev(ID);

        List<String> robots = dev.ROBOS.Split(',').ToList();

        return robots;
    }
}
}
