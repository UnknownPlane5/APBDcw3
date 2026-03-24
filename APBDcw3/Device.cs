namespace APBDcw3;

public abstract class Device
{
    public int id {get; set;}
    public string name { get; set; }
    public bool isAvailable { get; set; }

    public void SetAvailable(bool status)
    {
        isAvailable = status;
    }

    public abstract string GetDescription();
    public abstract string SetDescription(string newDescription);
}
