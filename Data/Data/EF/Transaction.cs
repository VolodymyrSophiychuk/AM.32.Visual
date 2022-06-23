namespace Data.EF
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public int Privilege { get; set; }
        public int Debt { get; set; }
        public int Payment { get; set; }
        public int PayerId { get; set; }

        public virtual Accounting? Payer { get; set; }

        public Transaction() { }
        public Transaction(DataGridViewCellCollection data)
        {
            Id = (int)data[0].Value;
            Date = DateOnly.Parse(data[1].Value.ToString());
            Amount = (int)data[2].Value;
            Price = (int)data[3].Value;
            Privilege = (int)data[4].Value;
            Debt = (int)data[5].Value;
            Payment = (int)data[6].Value;
            PayerId = (int)data[7].Value;
        }
    }
}
