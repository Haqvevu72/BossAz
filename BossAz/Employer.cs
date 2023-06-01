using System.Text.Json;
class Employer : Human
{
    public Vacancy? Vacancy{get;set;}

    public Employer(Guid id, string? name, string? surname, short? age, string? phone, string? city, string? username, string? password,Vacancy? vacancy) : base(id, name, surname, age, phone, city, username, password)
    {
        Vacancy = vacancy;
    }

    public void SeeCV() 
    {
        ConsoleKeyInfo key;
        string jsonCV = File.ReadAllText("C:\\Users\\Zver\\source\\repos\\BossAz\\BossAz\\CV.json");
        List<CV>CVs = JsonSerializer.Deserialize<List<CV>>(jsonCV);
        for (int i = 0; i < CVs.Count; i++)
        {
            while (true)
            {
                Console.Clear();
                if (CVs[i] != null)
                { Console.WriteLine(CVs[i].ToString()); }
                else { break; }
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
        
        return base.ToString() + Vacancy.ToString();
    }


}

