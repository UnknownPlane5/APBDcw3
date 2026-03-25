namespace APBDcw3;

public class Projector:Device
{
    public int Resolution { get; set; }
    public int Lumens { get; set; }

    public Projector(string name,  int resolution, int lumens):base(name)
    {
        Resolution = resolution;
        Lumens = lumens;
    }

    public override string GetSpecs()
    {
        return $"Projektor {name} ({Resolution}, {Lumens} lm)";
    }
}