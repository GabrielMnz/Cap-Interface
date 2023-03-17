// See https://aka.ms/new-console-template for more information



using Interface.Entities;
using Interface.Services;
using System.Globalization;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateOnly date = DateOnly.Parse(Console.ReadLine());
Console.Write("Contract value: ");
double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter number of installments: ");
int mouths = int.Parse(Console.ReadLine());

Contract contract = new Contract(number, date, value);

ContractService contractService = new ContractService(new PaypalService());
contractService.ProcessContract(contract, mouths);

Console.WriteLine("Installments:");
foreach (Installment installment in contract.Installments) {
    Console.WriteLine(installment);
}
