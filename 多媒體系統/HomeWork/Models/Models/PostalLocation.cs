using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RV
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PostalLocation
    {

        private string SectionField;

        private ushort PostalCodeField;

        private float LongitudeField;

        private float LatitudeField;

        private string tGOS_URLField;

        /// <remarks/>
        [XmlElementAttribute("行政區名")]
        [System.ComponentModel.DataAnnotations.Key]
        public string Section
        {
            get
            {
                return this.SectionField;
            }
            set
            {
                this.SectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("3碼郵遞區號")]
        [System.ComponentModel.DataAnnotations.Key]
        public ushort PostalCode
        {
            get
            {
                return this.PostalCodeField;
            }
            set
            {
                this.PostalCodeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("中心點經度")]
        [System.ComponentModel.DataAnnotations.Key]
        public float Longitude
        {
            get
            {
                return this.LongitudeField;
            }
            set
            {
                this.LongitudeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("中心點緯度")]
        [System.ComponentModel.DataAnnotations.Key]
        public float Latitude
        {
            get
            {
                return this.LatitudeField;
            }
            set
            {
                this.LatitudeField = value;
            }
        }

        /// <remarks/>
        [System.ComponentModel.DataAnnotations.Key]
        public string TGOS_URL
        {
            get
            {
                return this.tGOS_URLField;
            }
            set
            {
                this.tGOS_URLField = value;
            }
        }
    }
}
