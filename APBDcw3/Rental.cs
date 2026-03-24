namespace APBDcw3;

public class Rental
{
    public User WhoBorrowed;
    public Device BorrowedDevice;
    public DateTime DateOfBurrow;
    public DateTime DueDate;
    public DateTime DateOfReturn;
    public float InitialPayment;

    public Rental(User whoBorrowed, Device borrowedDevice, DateTime dateOfBurrow,
     DateTime dueDate,float initialPayment)
    {
        this.WhoBorrowed = whoBorrowed;
        this.BorrowedDevice = borrowedDevice;
        this.DateOfBurrow = dateOfBurrow;
        this.DueDate = dueDate;
        this.InitialPayment = initialPayment;
    }
    public decimal PenaltyFee;
    public void MarkAsReturned(DateTime returnDate, decimal penalty)
    {
        DateOfReturn = returnDate;
        PenaltyFee = penalty;
    }
}