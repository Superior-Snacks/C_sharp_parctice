using System;

namespace TypeConvertions{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            string number ="1230";
            int i = Convert.ToByte(number);
            System.Console.WriteLine(i);   
            }
            catch (Exception)
            {
                System.Console.WriteLine("error");
            }
        }
    }
}