namespace APBDcw3;

public abstract class User
{
    public static int Id { get; set; }
    public string Name{ get; set; }
    public string Surname { get; set; }
    public abstract int MaxRentalLimit { get; }    
    private static int idCounter = 1;
    protected User (int id, string name, string surname)
    {
        Id = idCounter++;
        Name = name;
        Surname = surname;
    }
}