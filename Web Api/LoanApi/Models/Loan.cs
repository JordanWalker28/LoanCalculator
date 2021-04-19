namespace LoanApi.Models
{
    public class Loan
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double BorrowingAmount { get; set; }
        public double RepaymentAmount { get; set; }
    }
}
