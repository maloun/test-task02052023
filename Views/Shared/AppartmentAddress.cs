using System.Xml.Linq;

namespace demo.Views.Shared
{
    public class AppartmentAddress
    {
        public string Street { get; set; }
        public string House { get; set; }
        public string ApartmentNumber { get; set; }

        public static AppartmentAddress FromXml(string xmlString)
        {
            var xml = XDocument.Parse($"<Адрес>{xmlString}</Адрес>").Root;

            return new AppartmentAddress
            {
                Street = xml.Element("Улица").Value,
                House = xml.Element("Дом").Value,
                ApartmentNumber = xml.Element("НомерКвартиры").Value
            };
        }
    }
}
