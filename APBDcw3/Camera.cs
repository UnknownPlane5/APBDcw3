namespace APBDcw3;

public class Camera:Device
{
    public CameraType cameraType;
    
    public bool canMakePhotosInTheDark;
    public Camera(string name, CameraType type, bool canMakePhotosInTheDark):base(name)
    {
        cameraType = type;
        this.canMakePhotosInTheDark = canMakePhotosInTheDark;
    }

    public override string GetSpecs()
    {
        string nightmode = canMakePhotosInTheDark ? "Tak" : "Nie";
        return $"Kamera {name} (Typ:{cameraType},Tryb nocny:{nightmode})";
    }
}

public enum CameraType
{
    Bullet,
    Dome,
    PTZ,
    BOX,
    Miniature
}