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

    public RentalService(User whoBorrowed, Device borrowedDevice, int dateOfBurrow, int dateOfReturn,
     float initialPayment)
    {
        this.whoBorrowed = whoBorrowed;
        this.borrowedDevice = borrowedDevice;
        this.dateOfBurrow = dateOfBurrow;
        this.dateOfReturn = dateOfReturn;
        this.initialPayment = initialPayment;
    }
    public float dailyPenaltyRate = 10.00f;
    public float CalculatePenalty(float dateOfBurrow, float dateOfReturn)
    {
        if (dateOfBurrow < dateOfReturn) return (dateOfBurrow - dateOfReturn)*dailyPenaltyRate;
        else return 0;
    }
}