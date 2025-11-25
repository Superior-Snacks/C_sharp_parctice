/* 
Operators Arithmatic, Comparison, assignment, logical, bitwise

Arithmatic:
add +, 1+2
subtract -, 1-2
multiply *, 1*2
divide /, 1/2
Remainder %, 1%2
increment ++, a = a+1 int a = 1; int b = a++; or int a = 1; int b = ++a;
decrement --, a = a-1

Comparison:
equal ==, a==b
notequal !=, a!=b
greater >, a>b
greater or equal >=, a>=b
lesser <, a<b 
lesser or equal <= a<=b

assignment:
assignment =, a = 1
addition assignment +=, a += 3
subtraction assignment -=,
multiplication assignment *=
division assignment /=

logical:
and &&, a&&b
or ||, a||b
not !, !a

bitwise:
and &, a& b
or |, a | b
*/
namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 12;
            var b = 5;
            System.Console.WriteLine(a + b * a);
            System.Console.WriteLine(a < b);
            if(a == b)
            {
                System.Console.WriteLine("piss");
            }
            else
            {
                System.Console.WriteLine("poos");
            }
        }
    }
}
