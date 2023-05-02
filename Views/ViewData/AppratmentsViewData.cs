using demo.Models.Database;
using System.Xml;

namespace demo.Views.ViewData
{
    public class AppartmentAddress
    {
        public string Street { get; set; }
        public string House { get; set; }
        public string ApartmentNumber { get; set; }

        public static AppartmentAddress FromXml(string xmlString) 
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml($"<Адрес>{xmlString}</Адрес>");
            var addressNode = xmlDoc.SelectSingleNode("//Адрес");
   
            return new AppartmentAddress
            {
                Street = addressNode.SelectSingleNode("Улица").InnerText,
                House = addressNode.SelectSingleNode("Дом").InnerText,
                ApartmentNumber = addressNode.SelectSingleNode("НомерКвартиры").InnerText
            };
        }  
    }

    public class AppartmentsViewData
    {
        public int Id { get; set; }

        public AppartmentAddress Address { get; set; }

        public MetersTable Meter { get; set; }

        public AppartmentsViewData(AppartmentsTable appartment)
        {
            Id = appartment.Id;
            Address = AppartmentAddress.FromXml(appartment.Name);
            Meter = appartment.Meter;
        }
    }
}
