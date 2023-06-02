using Newtonsoft.Json;

class Vacancy
{
	private string? jobtitle;
    public string? JobTitle
	{
		get { return jobtitle; }
        set
        {
                jobtitle = value;

        }
    }
    private string? requirements;
    public string? Requirements
    {
        get { return requirements; }
        set
        {

                requirements = value;

        }
    }
    public Notification? Notification { get; set; } = null;

    public Vacancy(string? jobTitle, string? requirements)
    {
        JobTitle = jobTitle;
        Requirements = requirements;
    }

    public void SeeNotif() 
    {
        Console.WriteLine(Notification.ToString());
    }
    public override string ToString()
    {
        return $"\nJob Title: {JobTitle}\nRequirements: {Requirements}";
    }
}

