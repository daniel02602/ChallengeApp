var name = "Daniel";
var age = 35;
bool isMen = true;
if (isMen == false && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (isMen == true && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
