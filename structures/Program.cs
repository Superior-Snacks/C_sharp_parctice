namespace structures
{
    class Program
    {
        struct Person
        {
            public string name;
            public int age;
            public int birthday;

            public Person(string name, int age, int birthday)
            {
                this.name = name;
                this.age = age;
                this.birthday = birthday;
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine(createPerson().age);
            Console.ReadLine();
        }
        static Person createPerson()
        {
            int age = 4;
            string name = "tom";
            int birhtday = 440;
            return new Person(name, age, birhtday);
        }
    }
}