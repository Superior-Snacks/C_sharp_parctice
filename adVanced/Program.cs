namespace adVanced
{
    class Program
    {
        delegate void LogDel(string text);

        static void Main(string[] args)
        {
            Console.WriteLine("lets begin");
            Console.ReadLine();
        }
        static void LogTExtToScreen( string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }
    }
}