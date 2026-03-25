namespace APBDcw3;

public abstract class Device
{
    public int id {get; set;}
    public string name { get;}
    public bool isAvailable { get; set; }

    protected Device(string name)
    {
        this.name = name;
    }

    public void SetAvailable(bool status)
    {
        isAvailable = status;
    }

    public abstract string GetSpecs();
}
