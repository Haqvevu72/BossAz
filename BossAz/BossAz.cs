using System.Text.Json;
using System.Threading;
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
            
            Console.Clear();
            Console.WriteLine("[1] Worker");
            Console.WriteLine("[2] Employer");
            Console.WriteLine("[3] Exit");
            Console.Write("Choice here...");
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.D1) { return 1; }
            else if (key.Key == ConsoleKey.D2) { return 2; }
            else if (key.Key == ConsoleKey.D3) { return 3; }
        }
    }
    static private Worker WorkerPassowordCheck() 
    {
        Console.Clear();
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
                return Workers[i]; 
            }
        }
        Workers.Clear();
        return null;
    }
    static private Employer EmployerPassowordCheck()
    {
        Console.Clear();
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
                return Employers[i];
            }
        }
        Employers.Clear();
        return null;
    }
    static private int SigninOrSignup() 
    {
        while (true) 
        {
            Console.Clear();
            Console.WriteLine("[1] Sign in");
            Console.WriteLine("[2] Sing up");
            Console.Write("Choice here...");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.D1) { return 1; }
            else if (key.Key == ConsoleKey.D2) { return 2; }
        }
    }
    static private void SignupWorker() 
    {
        Console.Clear();
        string username;
        Console.Write("Username: ");
        username= Console.ReadLine();

        string password;
        Console.Write("Password: ");
        password = Console.ReadLine();

        
        Worker newworker = new Worker(Guid.Empty, null, null, null, null, null, username, password, null);
        string jsonv = File.ReadAllText("C:\\Users\\Zver\\source\\repos\\BossAz\\BossAz\\Workers.json");
        Workers = JsonSerializer.Deserialize<List<Worker>>(jsonv);
        Workers.Add(newworker);

        List<CV> cvs = new List<CV>();
        for (int i =0 ; i < Workers.Count; i++)
        {
            cvs.Add(Workers[i].cv);
        }

        string jsoncv = JsonSerializer.Serialize(cvs);
        File.WriteAllText("C:\\Users\\Zver\\source\\repos\\BossAz\\BossAz\\CV.json", jsoncv);

        jsonv = JsonSerializer.Serialize(Workers);
        File.WriteAllText("C:\\Users\\Zver\\source\\repos\\BossAz\\BossAz\\Workers.json", jsonv);
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Successfully signed up!");
        Thread.Sleep(1500);
        Console.ResetColor();
    }
    static private void SignupEmployer() 
    {
        Console.Clear();
        string username;
        Console.Write("Username: ");
        username = Console.ReadLine();

        string password;
        Console.Write("Password: ");
        password = Console.ReadLine();


        Employer newemployer = new Employer(Guid.Empty, null, null, null, null, null, username, password, null);
        string jsonv = File.ReadAllText("C:\\Users\\Zver\\source\\repos\\BossAz\\BossAz\\Employers.json");
        Employers = JsonSerializer.Deserialize<List<Employer>>(jsonv);
        Employers.Add(newemployer);

        List<Vacancy> cvs = new List<Vacancy>();
        for (int i = 0; i < Employers.Count; i++)
        {
            cvs.Add(Employers[i].Vacancy);
        }

        string jsoncv = JsonSerializer.Serialize(cvs);
        File.WriteAllText("C:\\Users\\Zver\\source\\repos\\BossAz\\BossAz\\Vacancies.json", jsoncv);

        jsonv = JsonSerializer.Serialize(Employers);
        File.WriteAllText("C:\\Users\\Zver\\source\\repos\\BossAz\\BossAz\\Employers.json", jsonv);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Successfully signed up!");
        Thread.Sleep(1500);
        Console.ResetColor();
    }
    static public void start() 
    {
        while (true)
        {
            int wOre = WorkerOrEmployer();
            if (wOre == 1)
            {
                int sinorsup = SigninOrSignup();
                if (sinorsup == 1)
                {
                    Worker w = WorkerPassowordCheck();
                    if (w != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Access Successful !");
                        Console.ResetColor();

                        Thread.Sleep(1500);
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("[1] See Vacancies");
                            Console.WriteLine("[2] See Notifications");
                            Console.WriteLine("[3] Exit");
                            key = Console.ReadKey();
                            if (key.Key == ConsoleKey.D1) { w.SeeVacancy(); }
                            else if (key.Key == ConsoleKey.D2) { w.SeeNotif(); }
                            else if (key.Key == ConsoleKey.D3) { break; }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Access Denied !");
                        Console.ResetColor();
                        Thread.Sleep(1500);
                    }
                }
                else if (sinorsup == 2) 
                {
                    SignupWorker();
                }
               
            }
            else if (wOre == 2)
            {
                int Sinorsup = SigninOrSignup();
                if (Sinorsup == 1)
                {
                    Employer e = EmployerPassowordCheck();
                    if (e != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Access Successful !");
                        Console.ResetColor();
                        Thread.Sleep(1500);
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("[1] See CVs");
                            Console.WriteLine("[2] See Notification");
                            Console.WriteLine("[3] Exit");
                            key = Console.ReadKey();
                            if (key.Key == ConsoleKey.D1) { e.SeeCV(); }
                            else if (key.Key == ConsoleKey.D2) { e.SeeNotif(); }
                            else if (key.Key == ConsoleKey.D3) { break; }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Access Denied !");
                        Console.ResetColor();
                        Thread.Sleep(1500);
                    }
                }
                else if (Sinorsup==2) 
                {
                    SignupEmployer();
                }
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Thanks for using us !");
                break;
            }
        }
    }
}

