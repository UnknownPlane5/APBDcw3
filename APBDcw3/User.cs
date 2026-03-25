namespace APBDcw3;

public abstract class User
{
    protected int Id { get; set; }
    protected string Name{ get; set; }
    protected string Surname { get; set; }
    protected int MaxRentalLimit { get; }
}