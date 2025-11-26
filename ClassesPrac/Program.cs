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
    class Program
    {
        
    }
}
public class Person
{
    public string name; //field eð data

    public void Introduce() //function í class declare return efst þessi returnar ekkert ss void
    {
        System.Console.WriteLine("yo my name is "+ name);
    }
}
//Búa til objects í classið
Person jón1 = new Person();
jón1.name = "Jón1";
jón1.Introduce();

var jón2 = new Person();
jón2.name = "jón2";
jón2.Introduce();

Person person.jón3();
jón3.name = "Jón3";
jón3.Introduce();