namespace APBDcw3;

public abstract class Device
{
    public int id {get; set;}
    public string name { get; set; }
    public bool isAvailable { get; set; }
    protected string description { get; set; }
}
