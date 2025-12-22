namespace structures
{
    class Program
    {
        //struct fyrir einfalda hluti annars class
        class Person
        {
            private string name;
            private int age;



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
                        public void setName(string name)
            {
                if (!string.IsNullOrEmpty(name))
                {
                    this.name = name;
                }
                else
                {
                    this.name = "invalid name";
                }
            }
            public string ReturnDetails()
            {
                return $"name: {name}, age: {age}";
            }
        }


        static void Main(string[] args)
        {
            Person person = new Person("abba", 23);

            person.setName("tommy");
            Console.WriteLine(person.ReturnDetails());
            Console.ReadLine();
        }
    }
}