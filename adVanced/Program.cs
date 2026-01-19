namespace adVanced
{
    class Program
    {
        delegate void LogDel(string text);

        static void Main(string[] args)
        {
            LogDel logDel = new LogDel(LogTExtToScreen);

            logDel("text");


            Console.ReadLine();
        }
        static void LogTExtToScreen( string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }
    }
}