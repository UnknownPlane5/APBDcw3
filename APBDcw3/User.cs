namespace APBDcw3;

public abstract class User
{
    protected int id { get; set; }
    protected string name{ get; set; }
    protected string surname { get; set; }
    protected int maxRentalLimit { get; }
}