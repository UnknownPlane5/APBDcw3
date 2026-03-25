namespace APBDcw3;

public class Employee:User
{
    public override int MaxRentalLimit => 5;
    public Employee(String name, string surname) : base( Id,name, surname) {}
}