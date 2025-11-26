//held að classes eru bara functinos í python never mind það er meira eins og classes í python 
//ja fo sho u dummy

// type sem maður definar, havð er í því
//data represented by fields?
// behaviour sem er functionar sem ég minntist á áður

//dæmi: 1
/* 
    PERSON          nafnið á classinum
--------------
name: string
age: byte           datatypes í classinum
height: float       (fields)
weight: int
--------------
    walk()          behaviour
    talk()          functionar í classingum
    eat()           (methods)
    sleep()
--------------
*/
//dæmi: 2
/*
    Post
--------------------
Title: string
Description: string
DateTime: DateTime
--------------------
  Publish()
  Like()
  Comment(mesage)
--------------------
*/
//object oft talað um eins og classes:
//object er instance (notkun) af class í mynni tölvunar:
//þannig ekki Person classinn sjálfur heldur Jón objectið sem er person class

namespace classesPractice
{
    public class Person
{
        public string Name; //field eð data

        public void Introduce(string receever) //function í class declare return efst þessi returnar ekkert ss void
        {
            System.Console.WriteLine("good evening {0}, I am {1}", receever, Name);
        }
}
    class Program
    {
        static void Main(string[] args)
        {
        //Búa til objects í classið
        Person jón1 = new Person();
        jón1.Name = "Jón1";
        jón1.Introduce("tom");

        var jón2 = new Person();
        jón2.Name = "jón2";
        jón2.Introduce("mark");
        }
    }
}