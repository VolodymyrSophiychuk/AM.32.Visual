namespace Data.Templates
{
    public class JSONObject
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime Age { get; set; }
        public string? Country { get; set; }
        public string? Instrument { get; set; }

        public JSONObject() { }

        public JSONObject(DataGridViewCellCollection data)
        {
            Firstname = (string?)data[0].Value;
            Lastname = (string?)data[1].Value;
            Age = DateTime.Parse(data[2].Value.ToString());
            Country = (string?)data[3].Value;
            Instrument = (string?)data[4].Value;
        }
    }
}
