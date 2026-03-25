namespace APBDcw3;

public class RentalService
{
    private List<User> _users = new List<User>();
    private List<Device> _devices = new List<Device>();
    private List<Rental> _rentals = new List<Rental>();
    public const decimal DailyPenaltyRate = 10.00m;
    public void AddUser(User user)
    {
        _users.Add(user);
    }
    public void AddUsers(List<User> users)
    {
        foreach (var u in users)
        {
            _users.Add(u);
        }
    }
    public void AddDevice(Device device)
    {
        _devices.Add(device);
    }
    public void AddDevices(List<Device> devices)
    {
        foreach (var u in devices)
        {
            _devices.Add(u);
        }
    }


    public void DisplayAllDevices(List<Device> devices)
    {
        Console.WriteLine("------------------Devices----------------");
        foreach (var device in devices)
        {
            Console.WriteLine("|"+ device.GetSpecs() +"|Availability"+ device.isAvailable);
        }
    }
    public void DisplayAvailableDevices(List<Device> devices)
    {
        Console.WriteLine("------------------Devices----------------");
        foreach (var device in devices)
        {
            if(device.isAvailable) Console.WriteLine("|"+ device.GetSpecs());
        }
    }
    public Rental RentDevice(User user, Device device, DateTime dateOfBurrow,
        DateTime dueDate,float initialPayment)
    {
        var rental = new Rental(user, device, dateOfBurrow,
            dueDate,initialPayment);
        return rental;
    }

    public void ReturnDevice(Rental rental, DateTime dateOfReturn)
    {
        decimal penalty = 0;
        if (dateOfReturn > rental.DueDate)
        {
            penalty = (dateOfReturn-rental.DueDate).Days*DailyPenaltyRate;
        }
        rental.MarkAsReturned(dateOfReturn, penalty);
        rental.BorrowedDevice.isAvailable = true;
    }

    public void GenerateReport()
    {
        Console.WriteLine("Rental Report");
        Console.WriteLine("Liczba wypożyczeń:"+_rentals.Count);
        Console.WriteLine("Aktywne: "+_rentals.Count);
        Console.WriteLine("--------------------------");
    }
}