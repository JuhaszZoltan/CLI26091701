class Category
{
    private int survivals;
    private string name;

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrEmpty(value)) throw new Exception("nem lehet üres!");
            name = value;
        }
    }
    public int Survivals
    {
        get => survivals;
        set
        {
            if (value < 0 || value > 1000) throw new Exception("hülye vagy bazdmeg!");

            survivals = value;
        }
    }
    public int Missing { get; set; }
}