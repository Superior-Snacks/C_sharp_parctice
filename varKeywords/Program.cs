using System;

namespace varKeywords
{
    class Program
    {
        //þett er fínt fyrir augljosa hluti en bara betra að nota nákvæmari leiðina til að byrja með tbh
        static void Main(string[] args)
        {
            //int age = 24;
            //int age; leagal
            var age = 24; // þarf value
            Console.WriteLine(age);

            //long bigNumber = 900000000000L;
            var bigNumber = 9000000L;
            Console.WriteLine(bigNumber);

            var negative = -55.8D; // double
            Console.WriteLine(negative);

            var precision = 5.9999999900F; // float
            Console.WriteLine(precision);

            var money = 14.99M; //important
            Console.WriteLine(money);

            var name = "thomas";
            Console.WriteLine(name);

            var letter = 'c';
            Console.WriteLine(letter);

            Console.ReadLine();
        }
    }
}