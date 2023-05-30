using System.Text.Json;
class Employer : Human
{
	private List<Vacancy>? vacancies;
    public List<Vacancy>? Vacancies
	{
		get { return vacancies; }
        set
        {
            try
            {
                if (value == null) { throw new NullReferenceException("Vacancies cannot be null"); }
                vacancies = value;
            }
            catch (NullReferenceException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }

    public Employer(Guid id, string? name, string? surname, short? age, string? phone, string? city, string? username, string? password,List<Vacancy> vacancies) : base(id, name, surname, age, phone, city, username, password)
    {
        Vacancies = vacancies;
        
        // Serialize the object to JSON
        string json = JsonSerializer.Serialize(this);

        // Save the JSON to a file
        File.WriteAllText("C:\\Users\\Zver\\source\\repos\\BossAz\\BossAz\\Employers.json", json);
    }


  
    public override string ToString()
    {
        string? vacn= null;
        for (int i = 0; i < Vacancies.Count; i++)
        {
            vacn += Vacancies[i].ToString();
        }
        return base.ToString() + vacn;
    }


}

