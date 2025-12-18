namespace functionParamiters
{
    class Program
    {
        static void Main(string[] args)
        {
            string thePlan = "Two study sessions 1.5 hours long";
            string timeing = "vera mættur kl 8:30";
            string teikna = "Ég vil teikna á morgun";
            string method = "Teikna með 30 min timer";

            List<string> thoughts = new List<string>()
            {
                thePlan,
                timeing,
                teikna,
                method
            }

            static void writeToConsole(string sent)
            {
                for (int i = 0; i < sent.Length; i++)
                {
                    Console.Write(sent[i]);
                }
            }

            foreach (string tought in thoughts)
            {
                writeToConsole(tought)
            }

            
            Console.ReadLine();
        }
    }
}