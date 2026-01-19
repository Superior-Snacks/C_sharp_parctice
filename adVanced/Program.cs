namespace adVanced
{
    class Program
    {
        delegate void LogDel(string text);

        static void Main(string[] args)
        {
            Log log = new Log();


            LogDel LogTextToScreenDel, LogTextToFileDel;

            LogTextToFileDel = new LogDel(log.LogTextToFile);
            LogTextToScreenDel = new LogDel(log.LogTextToScreen);

            LogDel multiLog = LogTextToFileDel + LogTextToScreenDel;

            Console.Write("input name:");

            var name = Console.ReadLine();

            multiLog(name);
            
            Console.ReadLine();
        }
        
    }
    public class Log
    {
        public void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }

        public void LogTextToFile(string text)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt"), true))
            {
                sw.WriteLine($"{DateTime.Now}: {text}");
            }
        }
    }
}