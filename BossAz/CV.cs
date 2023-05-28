class CV {
	private string? speciality;
	public string? Speciality
	{
		get { return speciality; }
		set 
		{
			try
			{
				if (value == null) { throw new NullReferenceException("Speciality cannot be null"); }
				speciality = value;
			}
			catch (NullReferenceException ex)
			{
				Console.Clear();
				Console.WriteLine(ex.Message);
			}
		}
	}
	private string? school;
	public string? School
	{
		get { return school; }
        set
        {
            try
            {
                if (value == null) { throw new NullReferenceException("School cannot be null"); }
                school = value;
            }
            catch (NullReferenceException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }
	private short? point;
    public short? Point
	{
		get { return point; }
        set
        {
            try
            {
                if (value == null) { throw new NullReferenceException("Point cannot be null"); }
                else if (value < 0 || value > 700) { throw new InvalidDataException("Point must be greater than zero and less than 700"); }
                point = value;
            }
            catch (NullReferenceException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
            catch (InvalidDataException ex) 
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }
    private string? skills;
    public string? Skills
    {
        get { return skills; }
        set
        {
            try
            {
                if (value == null) { throw new NullReferenceException("Skills cannot be null"); }
                skills = value;
            }
            catch (NullReferenceException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }
    private List<Company>? companies;
    public List<Company>? Companies
    {
        get { return companies; }
        set
        {
            try
            {
                if (value == null) { throw new NullReferenceException("Companies cannot be null"); }
                companies = value;
            }
            catch (NullReferenceException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }
    private List<Languages>? languages;
    public List<Languages>? Languages
    {
        get { return languages; }
        set
        {
            try
            {
                if (value == null) { throw new NullReferenceException("Languages cannot be null"); }
                languages = value;
            }
            catch (NullReferenceException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }
    private bool? hasdiploma;
    public bool? HasDiploma
    {
        get { return hasdiploma; }
        set
        {
            try
            {
                if (value == null) { throw new NullReferenceException("HasDiploma cannot be null"); }
                hasdiploma = value;
            }
            catch (NullReferenceException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }
    private string? githublink;
    public string? Github
    {
        get { return githublink; }
        set
        {
            try
            {
                // https://github.com/Haqvevu72
                if (value == null) { throw new NullReferenceException("Github link cannot be null"); }
                else if (!value.Contains("github.com")) { throw new Exception("Invalid link"); }
                githublink = value;
            }
            catch (NullReferenceException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) 
            {
                Console.Clear();
                Console.WriteLine(ex.Message);            
            }
        }
    }
    private string? linkedin;
    public string? Linkedin
    {
        get { return linkedin; }
        set
        {
            try
            {
                // https://www.linkedin.com/in/elgun-haqverdiyev-a34134242/
                if (value == null) { throw new NullReferenceException("Linkedin link cannot be null"); }
                else if (!value.Contains("www.linkedin.com")) { throw new Exception("Invalid link"); }
                Linkedin = value;
            }
            catch (NullReferenceException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }

    public override string ToString()
    {
        string? cmp = null;
        for (int i = 0; i < Companies.Count; i++)
        {
            cmp += Companies[i].ToString();
        }
        string? lang = null;
        for (int i = 0; i < Languages.Count; i++)
        {
            lang += Languages[i].ToString();
        }
        return $"\nSpeciality: {Speciality}\nSchool: {School}\nPoint: {Point}\nSkills: {Skills}" +
            $"\nCompanies: {cmp}\nLangauges: {lang}\nHasDiploma: {HasDiploma}\nGithub Link: {Github}\nLinkedin link: {Linkedin}";
    }

}
