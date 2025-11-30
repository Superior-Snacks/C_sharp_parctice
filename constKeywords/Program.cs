namespace constKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            //ef talan er notuð oft og þarf alltaf að vera eins
            //í compiler const er bara find and replace tæknilega séð
            const int vat = 20;
            const double percentVAT = vat / 100D;

            int balance = 1000;

            Console.WriteLine(balance * (vat / 100D) ); //ef þarf að fá kommu stafi muna hverskonar tala etta er
            Console.WriteLine(balance * percentVAT);
            //vat = 10;
            Console.WriteLine(vat);
            Console.ReadLine();
        }
    }
}