namespace APBDcw3;

public class Laptop:Device
{
    public string Processor { get; set; }
    public int Ram { get; set; }

    public Laptop(string name, string processor, int ram):base(name)
    {
        Ram = ram;
        Processor = processor;
    }

    public override string GetSpecs()
    {
        return $"Laptop{name}(Procesor{Processor},{Ram}MB)";
    }

}