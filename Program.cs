using ArbeitLinq;
using System.Security.Cryptography;

var zahlen = new List<int>() { 3, 4 , 1, 6, 11, 8};

// create query
var nums = from num in zahlen
           orderby num ascending
           select num;

zahlen.Add(5);

// access nums
foreach (var x in nums)
{
    Console.WriteLine(x);
}

var nums2 = from num in zahlen
           where num % 3 == 0
           select num;

foreach (var x in nums2)
{
    Console.WriteLine(x);
}

var nums3 = from num in zahlen
            where num % 2 == 0
            where num > 2
            select num;

foreach (var x in nums3) {  Console.WriteLine(x); }

var nums4 = from num in zahlen
            where num % 2 == 0
            orderby num ascending
            select num;

foreach (var x in nums4) { Console.WriteLine(x); }

var personen = new List<string>() { "Oleksii Bilyi", "Ivana Vilnius", "Sebastian Orban", "Leo Lutschitsch" };

var leute = from num in personen
            where num.Contains("V")
               select num;

foreach (var x in leute) {  Console.WriteLine($"Name: {x}"); }

Console.WriteLine("********************************************************************");

List<Person> people = new List<Person>()
{
    new Person("Oleksii", "Huber", Gender.Male),
    new Person("Ivana", "Vilus", Gender.Male),
    new Person("Sebastian", "Huber", Gender.Male),
    new Person("Doris", "Mayer", Gender.Female),
    new Person("Daniela", "Huber", Gender.Female)
};

var LastNameHuber = from person in people
                    where person.LastName == "Huber"
                    select person;
/*
foreach (var x in LastNameHuber)
{
    Console.WriteLine($"Name: {x.FirstName} {x.LastName}");
}
*/

foreach (var person in people)
{
    Console.WriteLine(person);
}

Console.WriteLine("*******************************************");

var women = from person in people
             where person.Gender == Gender.Female
             select new PersonAnrede("Sehr geeherte Frau", person);

foreach (var person in women)
{
    Console.WriteLine(person.Anrede + " " + person.Item.LastName + "!"); // person.Item.Lastname: Man kann "Item" nicht weglassen, da wir im Select-Statement ein neues Objekt erstellt haben, das auf Person.Anrede basiert. Heißt man MUSS etwas aus dem Konstruktor von PersonenAnrede benutzen.
}

Console.WriteLine("*****************************************************");

var men = from person in people
          where person.Gender == Gender.Male
          select new { Anrede = "Sehr geehrter Herr", Lastname = person.LastName };

foreach (var person in men)
{
    Console.WriteLine(person.Anrede + " " + person.Lastname + "!");
}
Console.WriteLine("********************************************************");

var groups = from person in people
             group person by person.Gender; // bei Group kein "select"!

foreach (var group in groups)
{
    Console.WriteLine(group.Key); // group.Key in der CW zeigt alle Daten an, nach den Gruppiert werden können, wie zb. "Male" oder "Female"
    foreach(var p in group)
    {
        Console.WriteLine(p);
    }
}

List<Auto> cars = new List<Auto>()
{
    new Auto ("WI1216", 50),
    new Auto ("ZE7134", 100),
    new Auto ("ZE7135", 120),
    new Auto ("ZE7136", 130),
};

var automobile = from a in cars
                 
                 select cars;