namespace ExampleInterface.Services
{
    public class PaypalService : IOnlinePaymentService
    {
        private const double FeePErcentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double PaymentFee(double amount)
        {
            return amount * FeePErcentage;
        }

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }
    }
}