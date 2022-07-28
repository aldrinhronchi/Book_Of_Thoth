namespace Book_Of_Thoth.The_Great_Library_of_Alexandria
{
    internal class Debug
    {
        public void DebugInFile(string local, string responseMessage)
        {
            using (FileStream fs = new FileStream(local + @"\DEBUG.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(responseMessage.ToString());
                    sw.WriteLine("-------------------------------");
                    sw.WriteLine(responseMessage);
                    sw.WriteLine("-------------------------------");
                }
            }
        }
    }
}