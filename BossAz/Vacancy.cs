using Newtonsoft.Json;

class Vacancy
{
	private string? jobtitle;
    public string? JobTitle
	{
		get { return jobtitle; }
        set
        {
            try
            {
                if (value == null) { throw new NullReferenceException("Job title cannot be null"); }
                jobtitle = value;
            }
            catch (NullReferenceException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }
    private string? requirements;
    public string? Requirements
    {
        get { return requirements; }
        set
        {
            try
            {
                if (value == null) { throw new NullReferenceException("Requirements cannot be null"); }
                requirements = value;
            }
            catch (NullReferenceException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }

    public Vacancy(string? jobTitle, string? requirements)
    {
        JobTitle = jobTitle;
        Requirements = requirements;
    }

    public override string ToString()
    {
        return $"\nJob Title: {JobTitle}\nRequirements: {Requirements}";
    }
}

