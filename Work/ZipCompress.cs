using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using Book_Of_Thoth.The_Great_Library_of_Alexandria;

namespace Book_Of_Thoth.Work
{
    internal class ZipCompress
    {
        public static void Compress(string local, string xmlpath, string extension)
        {
            string cod = Generate.NameToken();
            //string path = Server.MapPath("~/Upload/") + cod;
            string path = local + cod;
            Directory.CreateDirectory(path);

            string zipPath = path + "/" + cod + ".zip";
            //ZipFile.CreateFromDirectory(startPath, zipPath);
            string[] files = Directory.GetFiles(xmlpath, extension);
            var zip = ZipFile.Open(zipPath, ZipArchiveMode.Create);
            foreach (var file in files)
            {
                // Add the entry for each file
                zip.CreateEntryFromFile(file, Path.GetFileName(file), CompressionLevel.Optimal);

            }
            zip.Dispose();
        }
        
    }
}
