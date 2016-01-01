using System.Collections.Generic;
using System.Xml.Serialization;

namespace LinqToTwitter
{
    [XmlType(Namespace = "LinqToTwitter")]
    public class VideoInfo
    {
        /// <summary>
        /// Aspect ratio information
        /// </summary>
        public List<int> AspectRatio { get; set; }

        /// <summary>
        /// Video display variants
        /// </summary>
        public List<Variant> Variants { get; set; }
    }
}
