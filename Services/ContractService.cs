using ExampleInterface.Entities;

namespace ExampleInterface.Services
{
    public class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        // Dependency injection.
        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double installmentValue = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);

                double updatedInstallment = installmentValue + _onlinePaymentService.Interest(installmentValue, i);
                double fullInstallment = updatedInstallment + _onlinePaymentService.PaymentFee(updatedInstallment);

                contract.AddInstallment(new Installment(dueDate, installmentValue));
            }
        }

    }
}