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
        device.isAvailable = true;
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
        Console.WriteLine("------------------Urządzenia----------------");
        foreach (var d in devices)
        {
            d.isAvailable = true;
            Console.WriteLine("|"+ d.GetSpecs() +"|Dostępność"+ d.isAvailable);
        }
    }
    public void DisplayAvailableDevices(List<Device> devices)
    {
        Console.WriteLine("------------------Urządzenia----------------");
        foreach (var device in devices)
        {
            if(device.isAvailable) Console.WriteLine("|"+ device.GetSpecs());
        }
    }
    public Rental RentDevice(User user, Device device, DateTime dateOfBurrow,
        DateTime dueDate,float initialPayment)
    {
        if (!device.isAvailable)
        {
            throw new Exception($"Błąd: Urządzenie {device.name} jest obecnie niedostępne.");
        }
        int activeUserRentals = _rentals.Count(r => r.WhoBorrowed == user && r.DateOfReturn == default(DateTime));
        if (activeUserRentals >= user.MaxRentalLimit)
        {
            throw new Exception($"Błąd: Użytkownik osiągnął swój maksymalny limit wypożyczeń ({user.MaxRentalLimit}).");
        }

        var rental = new Rental(user, device, dateOfBurrow, dueDate, initialPayment);
        
        device.isAvailable = false;
        _rentals.Add(rental);
        
        return rental;    }

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
        Console.WriteLine("Liczba wypożyczeń:"+ _rentals.Count);
        int activeRentals = _rentals.Count(r => r.DateOfReturn == default(DateTime));
        Console.WriteLine("Aktywne: "+activeRentals);
        Console.WriteLine("--------------------------");
    }
}