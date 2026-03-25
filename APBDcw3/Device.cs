namespace APBDcw3;

public abstract class Device
{
    public int Id {get; set;}
    public string name { get;}
    public bool isAvailable { get; set; }
    private static int idCounter = 1; 

    protected Device(string name)
    {
        Id = idCounter++;
        this.name = name;
    }

    public void SetAvailable(bool status)
    {
        isAvailable = status;
    }

    public abstract string GetSpecs();
}
