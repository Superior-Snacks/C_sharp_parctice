
// vars no consts
int numberSmall; // camel case convention
const int NumberBig = 10; // pascal case convention
const float Pi = 3.14;

//MIKILVÆGT FYRIR REAL numberSmall
float aNumber = 1.4F; // þarf að bæta f fyrir aftan því c# compiler telur öll real num sem double
decimal aBigNumber = 10.9M; // sama hér m fyrir aftan til að passa að talan er decimal
double normalNumber = 6; // þarf ekkert auka double er default

byte num = 255; // max num

num = num + 1; // 0 over flowr

byte anotherNum = 100;

checked
{
    byte safeByte = 255;
    safeByte = safeByte + 1; //exception þarft ekk ef það er möguleiki þá nota ér small data type
}

// identifiers 