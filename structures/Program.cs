using System.Threading.Channels;

namespace structures
{
    class Program
    {
        //struct fyrir einfalda hluti annars class
        class Person
        {
            private string name;
            private int age;

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }

            }
            public int Age { get => age; set => age = value; }


            public Person()
            {
                Name = default;
                Age = default;
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
            public string ReturnDetails()
            {
                return $"name: {name}, age: {age}";
            }
            public override string ToString()
            {
                return $"name: {name}, age: {age}";
            }
            public override bool Equals(object? obj)
            {
                if (obj is Person)
                {
                    Person person = obj as Person;
                    return Name.Equals(person.Name) && Age == person.Age;
                }
                else
                {
                    return false;
                }
                
            }
        }


        static void Main(string[] args)
        {
            Person person = new Person("abba", 23);
            person.Name = "Frank";
            Console.WriteLine(person.Name);
            person.Age = 400;
            Console.WriteLine(person.Age);
            Console.WriteLine(person.ReturnDetails());
            Console.WriteLine(person);

            Person test = new Person("Frank", 40);

            if (person.Equals(test))
            {
                Console.WriteLine(person);
                Console.WriteLine("SAME");
            }
            else
            {
                Console.WriteLine("NO BUENO");
            }



                Console.ReadLine();
        }
    }
}