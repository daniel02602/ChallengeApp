using ChallengeApp;

Employee user1 = new Employee("Daniel","Kowalski",35);
Employee user2 = new Employee("Monika","Nowak",33);
Employee user3 = new Employee("Lena","Duda",18);

user1.AddScore(8);
user1.AddScore(7);
user1.AddScore(6);

user2.AddScore(9);
user2.AddScore(8);
user2.AddScore(7);

user3.AddScore(10);
user3.AddScore(9);
user3.AddScore(8);

List<Employee> users = new List<Employee>()
{
    user1,user2,user3
};

int maxResult = -1;
Employee userWithMaxResult = null;

foreach (var user in users)
{
    if (user.result > maxResult)
    {
        maxResult = user.result;
        userWithMaxResult = user;
    }
}

Console.WriteLine("Najlepszy pracownik z najwyższą liczbą ocen: " + userWithMaxResult.name + " " + userWithMaxResult.lastname + " " + userWithMaxResult.age + " lat");
Console.WriteLine("Suma uzyskanych ocen:  " + maxResult) ;
