class Category
{
    public string Name { get; set; }
    public int Survivals { get; set; }
    public int Missing { get; set; }

    public override string ToString() =>
        $"\tkategórianév:   {Name}\n" +
        $"\ttúlélők száma:  {Survivals} fő\n" +
        $"\teltűntek száma: {Missing} fő";

    public Category(string row)
    {
        var tmp = row.Split(';');

        Name = tmp[0];
        Survivals = int.Parse(tmp[1]);
        Missing = int.Parse(tmp[2]);
    }
}