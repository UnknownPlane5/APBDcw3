namespace APBDcw3;

public class RentalService
{
    User whoBorrowed;
    Device borrowedDevice;
    private int dateOfBurrow;
    private int time;
    private int dateOfReturn;
    private float initialPayment;
    private string Punishment;

    public RentalService(User whoBorrowed, Device borrowedDevice, int dateOfBurrow, int time, int dateOfReturn,
     float initialPayment)
    {
        this.whoBorrowed = whoBorrowed;
        this.borrowedDevice = borrowedDevice;
        this.dateOfBurrow = dateOfBurrow;
        this.time = time;
        this.dateOfReturn = dateOfReturn;
        this.initialPayment = initialPayment;
    }

    public int CalculatePenalty()
    {
        return this.dateOfBurrow - this.dateOfReturn;
    }
}