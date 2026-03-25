namespace APBDcw3;

public class Student:User
{
    public override int MaxRentalLimit => 2;

    public Student(String name, string surname) : base( Id,name, surname) {}
}