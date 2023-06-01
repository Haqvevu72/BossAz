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

        string jsonv = File.ReadAllText("C:\\Users\\Haqve_vu72\\source\\repos\\BossAz\\BossAz\\Vacancies.json");
        List<Vacancy> vs = JsonSerializer.Deserialize<List<Vacancy>>(jsonv);
        vs.AddRange(Vacancies);

        jsonv = JsonSerializer.Serialize(vs);
        File.WriteAllText("C:\\Users\\Haqve_vu72\\source\\repos\\BossAz\\BossAz\\Vacancies.json", jsonv);
    }

    public void SeeCV() 
    {
        ConsoleKeyInfo key;
        string jsonCV = File.ReadAllText("C:\\Users\\Haqve_vu72\\source\\repos\\BossAz\\BossAz\\Vacancies.json");
        List<CV>CVs = JsonSerializer.Deserialize<List<CV>>(jsonCV);
        for (int i = 0; i < CVs.Count; i++)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(CVs[i].ToString());
                Console.WriteLine("[1] Next");
                Console.WriteLine("[2] Back");
                Console.WriteLine("[3] Exit");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1)
                {
                    if (i == CVs.Count - 1) { i = -1; }
                    break;
                }
                else if (key.Key == ConsoleKey.D2)
                {
                    if (i != 0) { i -= 2; }
                    else if (i == 0) { i -= 1; }
                    break;
                }
                else if (key.Key == ConsoleKey.D3) { i = CVs.Count - 1;break; }
            }
        }
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

