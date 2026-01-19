namespace adVanced
{
    class Program
    {
        delegate void LogDel(string text);

        static void Main(string[] args)
        {
            LogDel logDel = new LogDel(LogTextToFile);

            Console.Write("input name:");

            var name = Console.ReadLine();

            logDel(name);
            
            Console.ReadLine();
        }
        
    }
    public class log
    {
        void LogTExtToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }

        void LogTextToFile(string text)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt"), true))
            {
                sw.WriteLine($"{DateTime.Now}: {text}");
            }
        }
    }
}