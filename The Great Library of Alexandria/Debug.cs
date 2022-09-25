namespace Book_Of_Thoth.The_Great_Library_of_Alexandria
{
    internal class Debug
    {
        public void DebugInFile(string responseMessage, string place)
        {
            string localpath = @"D:\work\xmlcompress\Book_Of_Thoth\Book_Of_Thoth\Upload";
            using (FileStream fs = new FileStream($"{localpath}DEBUG/Main_Debug.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("*****************************************************");
                    sw.WriteLine(place.ToString());
                    sw.WriteLine("-----------------------------------------------------");
                    sw.WriteLine(responseMessage.ToString());
                    sw.WriteLine("=====================================================");
                }
            }
        }
        protected void Trying()
        {
            try
            {
                Console.WriteLine("DO IT!");
            }
            catch (Exception ex)
            {
                DebugInFile(ex.Message, "Erro");
            }
        }

    }
}