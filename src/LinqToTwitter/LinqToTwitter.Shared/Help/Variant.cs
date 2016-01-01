using System.Xml.Serialization;

namespace LinqToTwitter
{
    [XmlType(Namespace = "LinqToTwitter")]
    public class Variant
    {
        public int BitRate { get; set; }

        public string ContentType { get; set; }

        public string Url { get; set; }
    }
}
