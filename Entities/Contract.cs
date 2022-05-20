namespace ExampleInterface.Entities
{
    public class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> LitsOfInstallments = new List<Installment>();

        public Contract()
        {

        }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public void AddInstallment(Installment installment)
        {
            LitsOfInstallments.Add(installment);
        }
    }
}