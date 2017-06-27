using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RV
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PostalLocation
    {

        private string DistrictNameField;

        private ushort PostalCodeField;

        private decimal LongitudeField;

        private decimal LatitudeField;

        private string tGOS_URLField;

        /// <remarks/>
        public string DistrictName
        {
            get
            {
                return this.DistrictNameField;
            }
            set
            {
                this.DistrictNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("3碼郵遞區號")]
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
        public decimal Longitude
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
        public decimal Latitude
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
