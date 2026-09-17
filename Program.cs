Category cat = new()
{
    Name = "",
    Survivals = 200,
    Missing = 50
};

Console.WriteLine(cat is not null  ? "oké" : "nem oké");