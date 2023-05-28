class Languages
{
	private string? language;
	public string? Language
	{
		get { return language; }
		set 
		{
			try
			{
				if (value == null) { throw new NullReferenceException("Language cannot be null"); }
				language = value;
			}
			catch (NullReferenceException ex) {
				Console.Clear();
				Console.WriteLine(ex.Message);
			}
		}
	}
	private string? level;
    public string? Level
	{
		get { return level; }
        set
        {
            try
            {
                if (value == null) { throw new NullReferenceException("Level cannot be null"); }
                level = value;
            }
            catch (NullReferenceException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }

    public Languages(string? language, string? level)
    {
        Language = language;
        Level = level;
    }


    public override string ToString()
    {
		return $"Language: {Language}\tLevel: {Level}\n";
    }
}

