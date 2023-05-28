using System.Text.Json;
class Program {
    static void Main(string[] args)
    {
        //Company c1 = new Company("Microsoft", new DateTime(2004,6,5),new DateTime(2005,6,5));
        Worker w1 = new Worker(Guid.NewGuid(),"Elgun", "Haqverdiyev", 19, "508704253", "Baku","Elgun2004","Elgun2004",
            new CV()
            {
                Speciality = "Back-End developer",
                School = "ASOIU",
                Point = 610,
                Skills = "Python,C++,C#",
                Companies = new List<Company>(){
                          new Company("Microsoft",new DateTime(2004,6,5),new DateTime(2005,6,5))
                      },
                Languages = new List<Languages>() {
                          new Languages("English","B2-Upper Intermediate")  
                },
                HasDiploma=false,
                Github ="github.com/Haqvevu72",
                Linkedin="linkedin.com/Haqvevu72"

            });
    }
}
