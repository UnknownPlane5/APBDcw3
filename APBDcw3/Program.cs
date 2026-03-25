using System.Collections;

namespace APBDcw3;

class Program
{
    public static void Main(string[] args)
    {
        var service = new RentalService();
        var s1 = new Student();
        var s2 = new Student();
        var s3 = new Student();
        var e1 = new Employee();
        var e2 = new Employee();
        var e3 = new Employee();
        var clients = new List<User>{s1, s2, s3, e1, e2, e3};
        service.AddUsers(clients);
        var lap1 = new Laptop();
        var proj1 = new Projector();
        var camera1 = new Camera();
        var devices = new List<Device>{lap1, proj1, camera1};
        service.AddDevices(devices);
        var rental =service.RentDevice(s1, lap1,,,);
        try
        {
            Console.WriteLine("");
            service.RentDevice()
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        service.ReturnDevice(rental,);
        service.GenerateReport();
    }
}