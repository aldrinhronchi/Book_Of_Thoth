using System.Xml;

namespace Book_Of_Thoth.Work
{
    internal class Tools
    {
        private object path;
        private string localpath;

        public void GetFiscalNotes()
        {
            List<String> a = File.ReadAllLines(@"C:\Users\Terore\Desktop\ConceptOne\Task\FIDCRevenda\Tests\numbersxml.txt").ToList();
            string Danfe;
            DirectoryInfo dirInfo = new DirectoryInfo(localpath);
            foreach (string line in a)
            {
                foreach (FileInfo file in dirInfo.GetFiles("*.xml"))
                {
                    try
                    {
                        XmlDocument xml = new XmlDocument();
                        xml.PreserveWhitespace = true;
                        xml.Load(file.FullName);

                        XmlNamespaceManager xmlnsManager = new XmlNamespaceManager(xml.NameTable);
                        xmlnsManager.AddNamespace("nfe", "http://www.portalfiscal.inf.br/nfe");

                        XmlNodeList ChaveNota = xml.SelectNodes("//nfe:infNFe", xmlnsManager);
                        if (ChaveNota.Count > 0)
                        {
                            XmlNode Chave = ChaveNota[0];
                            Danfe = Chave.Attributes["Id"].Value;
                            if (Danfe == line)
                            {
                                System.IO.File.Copy(file.FullName, $"{path}/{file.Name}", true);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string exce = ex.Message;
                        Console.WriteLine(exce);
                    }
                }
            }
        }
    }
}