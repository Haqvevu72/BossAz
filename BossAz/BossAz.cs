using System.Text.Json;

class BossAz
{
    static private List<Worker>? Workers { get; set; }
    static private List<Employer>? Employers { get; set; }

    // [1] Worker
    // [2] Employer
    // [3] Exit
    static private ConsoleKeyInfo key;
    static private int WorkerOrEmployer()
    {
        while (true)
        {
            Console.WriteLine("[1] Worker");
            Console.WriteLine("[2] Employer");
            Console.WriteLine("[3] Exit");
            Console.Write("Choice here...");
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.D1) { return 1; }
            else if (key.Key == ConsoleKey.D2) { return 2; }
            else if (key.Key == ConsoleKey.D3) { return 3; }
            Console.Clear();
        }
    }
    static public bool WorkerPassowordCheck() 
    {
        string workers = File.ReadAllText("C:\\Users\\Zver\\source\\repos\\BossAz\\BossAz\\Workers.json");
        Workers = JsonSerializer.Deserialize<List<Worker>>(workers);
        
        string username;
        Console.Write("Username: ");
        username = Console.ReadLine();

        string passwprd;
        Console.Write("Passowrd: ");
        passwprd = Console.ReadLine();

        for (int i = 0; i<Workers.Count; i++)
        {
            if (Workers[i].Username == username && Workers[i].Password == passwprd) 
            {
                return true; 
            }
        }
        return false;
    }
    static public bool EmployerPassowordCheck()
    {
        string employers = File.ReadAllText("C:\\Users\\Zver\\source\\repos\\BossAz\\BossAz\\Employers.json");
        Employers = JsonSerializer.Deserialize<List<Employer>>(employers);

        string username;
        Console.Write("Username: ");
        username = Console.ReadLine();

        string passwprd;
        Console.Write("Passowrd: ");
        passwprd = Console.ReadLine();

        for (int i = 0; i < Employers.Count; i++)
        {
            if (Employers[i].Username == username && Employers[i].Password == passwprd)
            {
                return true;
            }
        }
        return false;
    }
}

