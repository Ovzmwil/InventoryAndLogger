namespace DevProProjectTest.Tests
{
    public static class Logger
    {

        public static void LogMessage(string outputFile, string logMessage, string logLevel)
        {
            string dateFormat = "yyyy/MM/dd HH:mm:ss";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter file = new StreamWriter(Path.Combine(docPath, outputFile), true))
            {
                file.WriteLine($"[{DateTime.Now.ToString(dateFormat)}] [{logLevel}] {logMessage}");
            }
        }
    }
}
