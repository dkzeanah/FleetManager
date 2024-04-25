namespace BlazorApp1.CarModels
{
    public class Loan
    {
        public decimal PrincipalAmount { get; set; }
        public decimal AnnualInterestRate { get; set; }
        public int LoanTermYears { get; set; }

        public decimal CalculateMonthlyPayment()
        {
            var monthlyInterestRate = AnnualInterestRate / 12 / 100;
            var totalPayments = LoanTermYears * 12;
            return PrincipalAmount * (monthlyInterestRate * (decimal)Math.Pow(1 + (double)monthlyInterestRate, totalPayments)) / (decimal)(Math.Pow(1 + (double)monthlyInterestRate, totalPayments) - 1);
        }
    }
}
