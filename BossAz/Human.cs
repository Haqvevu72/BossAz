abstract class Human
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    private short? age;
    public short? Age
    {
        get { return age; }
        set
        {
            try
            {
                if (value <= 0) { throw new Exception("Age cannot be zero or negative"); }
                age = value;
            }
            catch(Exception ex) 
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }
    private string? phone;
    public string? Phone
    {
        get { return phone; }
        set
        {
            try
            {
                if (value!=null && value.Length!=9) { throw new Exception("Phone number must be contains 9 digit"); }
                phone = value;
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }
    public string? City { get; set; }
    private string? username;
    public string? Username
    {
        get { return username; }
        set
        {
            try
            {
                if (value == null) { throw new NullReferenceException("Username cannot be null"); }
                username = value;
            }
            catch (NullReferenceException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }
    private string? password;
    public string? Password
    {
        get { return password; }
        set
        {
            try
            {
                if (value == null) { throw new NullReferenceException("Password cannot be null"); }
                else if (value.Length < 8) { throw new Exception("Password must contain at least 8 item"); }
                password = value;
            }
            catch (NullReferenceException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex) 
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }

    protected Human(Guid id, string? name, string? surname, short? age, string? phone, string? city, string? username, string? password)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Age = age;
        Phone = phone;
        City = city;
        Username = username;
        Password = password;
    }
    
    public override string ToString()
    {
        return $"Id: {Id}\tName: {Name}\tSurname: {Surname}\tAge: {Age}\tPhone: {Phone}\tCity: {City}";
    }
}
