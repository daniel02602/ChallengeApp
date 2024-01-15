var imie = "Daniel";
var wiek = 35;
bool plec = true; // true = mężczyzna , false = kobieta
if (plec == false && wiek > 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (imie == "Ewa" && wiek == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (plec == true && wiek < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{

}
