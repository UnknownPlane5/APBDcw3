using System.Collections;

namespace APBDcw3;

class Program
{
    public static void Main(string[] args)
    {
        var service = new RentalService();
        
        var s1 = new Student("Jan", "Kowalski");
        var s2 = new Student("Anna", "Nowak");
        var s3 = new Student("Piotr", "Wiśniewski");
        
        var e1 = new Employee("Adam", "Małysz");
        var e2 = new Employee("Robert", "Lewandowski");
        var e3 = new Employee("Iga", "Świątek");
        
        var clients = new List<User>{s1, s2, s3, e1, e2, e3};
        service.AddUsers(clients);
        
        var lap1 = new Laptop("Dell XPS", "Intel i7", 16384);
        var proj1 = new Projector("Epson", 1920, 3000);
        var camera1 = new Camera("Sony Alpha", CameraType.Dome, true);
        
        var devices = new List<Device>{lap1, proj1, camera1};
        service.AddDevices(devices);
        
        DateTime borrowDate = DateTime.Now;
        DateTime dueDate = DateTime.Now.AddDays(7);
        float initialPayment = 100.0f;
        
        var rental = service.RentDevice(s1, lap1, borrowDate, dueDate, initialPayment);
        
        try
        {
            Console.WriteLine("Próba kolejnego wypożyczenia...");
            service.RentDevice(s2, proj1, DateTime.Now, DateTime.Now.AddDays(3), 50.0f);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        DateTime returnDate = borrowDate.AddDays(9); 
        service.ReturnDevice(rental, returnDate);
        
        service.GenerateReport();
        
        Console.WriteLine($"Kara za spóźnienie pierwszego wypożyczenia: {rental.PenaltyFee} zł");
    }
}