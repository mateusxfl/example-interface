using System.Globalization;
using ExampleInterface.Entities;
using ExampleInterface.Services;

Console.Clear();

Console.WriteLine("Enter contract data:\n");

Console.Write("Number: ");
int contractNumber = int.Parse(Console.ReadLine());

Console.Write("Date (dd/MM/yyyy): ");
DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

Console.Write("Contract value: ");
double contractValue = double.Parse(Console.ReadLine());

Console.Write("Enter number of installments: ");
int numberOfInstallments = int.Parse(Console.ReadLine());

Console.Clear();

var contract = new Contract(contractNumber, contractDate, contractValue);

var contractService = new ContractService(new PaypalService());

contractService.ProcessContract(contract, numberOfInstallments);

foreach (var installment in contract.LitsOfInstallments)
{
    Console.WriteLine(installment);
}




