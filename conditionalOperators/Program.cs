namespace conditionalOperators
{
    class project
    {
        static void Main(string[] args)
        {
            Console.Write("type age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //the conditional operator, string nameVar = condition ? "trueOutput" : "falseOutput";
            //aðalega til að einfalda if then statements mikilvægt fyrir lesanlegan kóða
            string output = age > 0 && age < 150 ? "Valid Age!" : "Suspect age?";
            Console.WriteLine(output);

            //ennþá betri leið
            Console.WriteLine(age >= 0 && age <= 150 ? "Valid Age!" : "Suspect age?");
            Console.ReadLine();
        }
    }
}