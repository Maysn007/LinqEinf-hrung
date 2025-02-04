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
               select num;

foreach (var x in leute) {  Console.WriteLine(x); }