namespace structures
{
    class Program
    {
        class Person
        {
            public string name;
            public int age;

            public Person()
            {
                this.name = default;
                this.age = default;
            }
            public Person(string name)
            {
                this.name = name;
                this.age = default;
            }
            public Person(int age)
            {
                this.name = default;
                this.age = age;
            }
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }


        static void Main(string[] args)
        {
            Person person = new Person("abba");

            Console.WriteLine(person.name);
            Console.WriteLine(person.age);
            Console.ReadLine();
        }
    }
}