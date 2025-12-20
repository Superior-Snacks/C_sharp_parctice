namespace structures
{
    class Program
    {
        struct Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }



        static void Main(string[] args)
        {
            Person person = new Person("abba", 3);

            Console.WriteLine(person.name);
            Console.WriteLine(person.age);
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