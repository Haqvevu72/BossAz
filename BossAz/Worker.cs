using System.Text.Json;

class Worker : Human
{
    public CV? cv { get; set; }
    ConsoleKeyInfo key;
    public Worker(Guid id, string? name, string? surname, short? age, string? phone, string? city, string? username, string? password, CV? cv) : base(id, name, surname, age, phone, city, username, password)
    {
        this.cv = cv;
    }

    public void SeeVacancy()
    {
        string jsonV = File.ReadAllText("C:\\Users\\Zver\\source\\repos\\BossAz\\BossAz\\Vacancies.json");
        List<Vacancy> vaca = JsonSerializer.Deserialize<List<Vacancy>>(jsonV);
        for (int i = 0; i < vaca.Count; i++)
        {
            while (true)
            {
                Console.Clear();
                if (vaca[i] != null)
                { Console.WriteLine(vaca[i].ToString()); }
                else { break; }
                Console.WriteLine("[1] Next");
                Console.WriteLine("[2] Back");
                Console.WriteLine("[3] Send Notification");
                Console.WriteLine("[4] Exit");
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
                else if (key.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    string message;
                    Console.Write("Your Message: ");
                    message = Console.ReadLine();
                    vaca[i].Notification = new Notification(this.Name, message);
                    break;
                }
                else if (key.Key == ConsoleKey.D4)
                {
                    i = vaca.Count - 1;
                    break;
                }
            }
        }
        jsonV = JsonSerializer.Serialize(vaca);
        File.WriteAllText("C:\\Users\\Zver\\source\\repos\\BossAz\\BossAz\\Vacancies.json", jsonV);
    }

    public void SeeNotif() 
    {
        while (true)
        {
            Console.Clear();
            cv.SeeNotif();
            Console.WriteLine("[1] Exit");
            Console.Write("Choice here...");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.D1) { break; }
        }
        
    }

    public override string ToString()
    {
        return base.ToString() + cv.ToString();
    }
}
