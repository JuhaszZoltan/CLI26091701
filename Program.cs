using System.Text;
#nullable disable
const string FilePath = "..\\..\\..\\data\\titanic.txt";
List<Category> categories = [];
using StreamReader sr = new(FilePath, Encoding.UTF8);
while (!sr.EndOfStream) categories.Add(new(sr.ReadLine()));
Console.WriteLine($"kategóriák száma: {categories.Count} db");
var f3 = categories.Sum(c => c.Passengers);
Console.WriteLine($"utasok száma: {f3} fő");
Console.Write($"írja be a keresési kulcsszót: ");
string f4kw = Console.ReadLine();
var f4res = categories.Any(c => c.Name.Contains(f4kw));
Console.WriteLine($"'{f4kw}' kulcsszókeresésre a kategóriák neveiben:\n\t" +
    $"{(f4res ? "VAN" : "NINCS")} TALÁLAT");
if (f4res)
{
    var f5 = categories.Where(c => c.Name.Contains(f4kw));
    Console.WriteLine($"azon utaskategóriák, melyek nevében szerepel a '{f4kw}':");
    foreach (var c in f5) Console.WriteLine($"\t{c.Name, -25} {c.Passengers, 3} fő");
}
var f6lst = categories.Where(c => c.Missing > c.Passengers * .6).Select(c => c.Name);
Console.WriteLine("azon kategóriák listája, ahol a eltűntek aránya meghaladja a 60%-ot:");
foreach (var cn in f6lst) Console.WriteLine($"\t{cn}");
var f7 = categories.MaxBy(c => c.Survivals);
Console.WriteLine($"legtöbb túlélő:\n{f7}");

Console.WriteLine("utasok száma jegykategóriánként:");
var f8grp = categories.GroupBy(c => c.Name.Split('-')[1]);
foreach (var g in f8grp) Console.WriteLine($"\t{g.Key} {g.Sum(c => c.Passengers)} fő");

//IMERATÍV (C#, Python, JS, PHP) [HOGYAN?] <---> DELKATATÍV (html, SQL) [MIT?]

/*
    int sum = 0;
    for (int i = 0; i < categories.Count; i++)
    {
        sum = sum + categories[i].Missing + categories[i].Survivals;
    }
    Console.WriteLine($"osszes utas: {sum}");
*/

/*
    SELECT SUM(missing + survivals) FROM categories;
*/

