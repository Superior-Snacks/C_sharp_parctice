namespace adVanced
{
    class Program
    {
        delegate void LogDel(string text);

        static void Main(string[] args)
        {
            Console.ReadLine();
        }
        static void LogTExtToScreen( string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }
    }
}