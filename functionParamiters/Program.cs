namespace functionParamiters
{
    class Program
    {
        static void Main(string[] args)
        {
            string thePlan = "Two study sessions 1.5 hours long";
            string teikna = "Ég vil teikna á morgun";
            string method = "Teikna með 30 min timer";

            List<string> thoughts = new List<string>()
            {
                thePlan,
                teikna,
                method
            };

            static void writeToConsole(string sent)
            {
                for (int i = 0; i < sent.Length; i++)
                {
                    Thread.Sleep(200);
                    Console.Write(sent[i]);
                }
            }

            foreach (string tought in thoughts)
            {
                writeToConsole(tought);
                Console.WriteLine();
            }

            
            Console.ReadLine();
        }
    }
}