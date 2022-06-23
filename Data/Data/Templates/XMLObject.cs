using System.Xml.Serialization;

namespace Data.Templates
{
    [XmlRoot("XMLObject")]
    public class XMLObject
    {
        public DateTime CallDate { get; set; }
        public int TownCode { get; set; }
        public string? TownName { get; set; }
        public int CallDuration { get; set; }
        public string? Tariff { get; set; }
        public string? PhoneNumber { get; set; }

        public XMLObject()
        {

        }
        public XMLObject(DataGridViewCellCollection data)
        {
            CallDate = DateTime.Parse(data[0].Value.ToString());
            TownCode = (int)data[1].Value;
            TownName = (string?)data[2].Value;
            CallDuration = (int)data[3].Value;
            Tariff = (string?)data[4].Value;
            PhoneNumber = (string?)data[5].Value;
        }
    }
}
