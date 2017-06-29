namespace RV.Services
{
    public class PostalLocationService
    {

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute("dataroot", Namespace = "", IsNullable = false)]
        public partial class XML
        {

            private PostalLocation[] item1050429_行政區經緯度toPostField;

            private System.DateTime generatedField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("1050429_行政區經緯度(toPost)")]
            public PostalLocation[] Item1050429_行政區經緯度toPost
            {
                get
                {
                    return this.item1050429_行政區經緯度toPostField;
                }
                set
                {
                    this.item1050429_行政區經緯度toPostField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public System.DateTime generated
            {
                get
                {
                    return this.generatedField;
                }
                set
                {
                    this.generatedField = value;
                }
            }
        }
    }

}