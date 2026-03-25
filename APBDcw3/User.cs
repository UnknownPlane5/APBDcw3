namespace APBDcw3;

public abstract class User
{
    protected static int Id { get; set; }
    protected string Name{ get; set; }
    protected string Surname { get; set; }
    public abstract int MaxRentalLimit { get; }
    protected User (int id, string name, string surname)
    {
        Id = id;
        Name = name;
        Surname = surname;
    }
}