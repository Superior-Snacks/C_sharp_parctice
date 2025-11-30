namespace storingUserData
{
    class Program
    {
        /*
        Define Variable to hold name
        Define variable to hold Phone number
        Define variable to hold age
        print variables line by line to the screen
        Extra define variables using the var keyword
         */
        static void Main(string[] args)
        {
            //fist way
            string name = "Theodore Rosavelt";
            string phoneNumber= "0123456789";
            int age = 60;

            Console.WriteLine(name);
            Console.WriteLine(phoneNumber);
            Console.WriteLine(age);
            Console.WriteLine("press enter to see it again");

            Console.ReadLine();
            
            var Vname = "Thomas Jefferson";
            var VPhoneNumber = "0123456789";
            var Vage = 48; // nú þegar int32
            
            Console.WriteLine(Vname);
            Console.WriteLine(VPhoneNumber);
            Console.WriteLine(Vage);
            Console.ReadLine();

        }
    }
}