class Company
{
	private string? name;
    public string? Name
	{
		get { return name; }
        set
        {
            try
            {
                if (value == null) { throw new NullReferenceException("Name cannot be null"); }
                name = value;
            }
            catch (NullReferenceException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }
    public DateTime Finish { get; set; }
    public DateTime Start { get; set; }

    public Company(string? name, DateTime start, DateTime finish)
    {
        Name = name;
        Start = start;
        Finish = finish;
    }

    public override string ToString()
    {
        return $"Name: {Name}\t  Start Time: {Start.ToShortDateString()}\t  Finish Time: {Finish.ToShortDateString()}\n";
    }
}

