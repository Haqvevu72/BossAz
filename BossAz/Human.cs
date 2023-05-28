abstract class Human
{
    public Guid Id { get; set; }
    private string? name;
    public string? Name
    {
        get { return name; }
        set
        {
            try
            {
                if (value == null) { throw new NullReferenceException("Name cannot be null"); }
                name = value;
            }
            catch (NullReferenceException ex) {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }
    private string? surname;
    public string? Surname
    {
        get { return surname; }
        set
        {
            try
            {
                if (value == null) { throw new NullReferenceException("Surname cannot be null"); }
                surname = value;
            }
            catch (NullReferenceException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }
    private short? age;
    public short? Age
    {
        get { return age; }
        set
        {
            try
            {
                if (value == null) { throw new NullReferenceException("Age cannot be null"); }
                else if (value <= 0) { throw new Exception("Age cannot be zero or negative"); }
                age = value;
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
    private string? phone;
    public string? Phone
    {
        get { return phone; }
        set
        {
            try
            {
                if (value == null) { throw new NullReferenceException("Phone number cannot be null"); }
                else if (value.Length!=9) { throw new Exception("Phone number must be contains 9 digit"); }
                phone = value;
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
    private string? city;
    public string? City
    {
        get { return city; }
        set
        {
            try
            {
                if (value == null) { throw new NullReferenceException("Age cannot be null"); }
                city = value;
            }
            catch (NullReferenceException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }

    protected Human(Guid id, string? name, string? surname, short? age, string? phone, string? city)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Age = age;
        Phone = phone;
        City = city;
    }


    public override string ToString()
    {
        return $"Id: {Id}\tName: {Name}\tSurname: {Surname}\tAge: {Age}\tPhone: {Phone}\tCity: {City}";
    }
}
