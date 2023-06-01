using System.Text.Json;

class Worker : Human
{
    public CV? cv { get; set; }
    public Worker(Guid id, string? name, string? surname, short? age, string? phone, string? city, string? username, string? password,CV? cv) : base(id, name, surname, age, phone, city, username, password)
    {
        this.cv = cv;
        string jsonv = File.ReadAllText("C:\\Users\\Haqve_vu72\\source\\repos\\BossAz\\BossAz\\CV.json");
        List<CV> vs = JsonSerializer.Deserialize<List<CV>>(jsonv);
        vs.Add(cv);

        jsonv = JsonSerializer.Serialize(vs);
        File.WriteAllText("C:\\Users\\Haqve_vu72\\source\\repos\\BossAz\\BossAz\\CV.json", jsonv);
    }

    public void SeeVacancy() 
    {
        ConsoleKeyInfo key;
        string jsonV = File.ReadAllText("C:\\Users\\Zver\\source\\repos\\BossAz\\BossAz\\Vacancies.json");
        List<Vacancy> vaca = JsonSerializer.Deserialize<List<Vacancy>>(jsonV);
        for (int i = 0; i < vaca.Count; i++)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(vaca[i].ToString());
                Console.WriteLine("[1] Next");
                Console.WriteLine("[2] Back");
                Console.WriteLine("[3] Exit");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1)
                {
                    if (i == vaca.Count - 1) { i = -1; }
                    break;
                }
                else if (key.Key == ConsoleKey.D2)
                {
                    if (i != 0) { i -= 2; }
                    else if (i == 0) { i -= 1; }
                    break;
                }
                else if (key.Key == ConsoleKey.D3) { i = vaca.Count-1;break; }
            }
        }
    }

    public override string ToString()
    {
        return base.ToString()+cv.ToString();
    }
}
