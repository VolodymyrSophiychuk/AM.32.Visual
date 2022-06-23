namespace Data.EF
{
    public partial class Accounting
    {
        public int Id { get; set; }
        public string? Payer { get; set; }
        public int Code { get; set; }
        public string? Address { get; set; }
        public string? Agreement { get; set; }
        public string? Institution { get; set; }
        public int Phone { get; set; }

        public virtual List<Transaction>? Transactions { get; set; }

        public Accounting() { }
        public Accounting(DataGridViewCellCollection data)
        {
            Id = (int)data[0].Value;
            Payer = (string?)data[1].Value;
            Code = (int)data[2].Value;
            Address = (string?)data[3].Value;
            Agreement = (string?)data[4].Value;
            Institution = (string?)data[5].Value;
            Phone = (int)data[6].Value;
        }
    }
}
