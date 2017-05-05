using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Postal
    {

        private int PostalCodeField;

        private string SectionField;

        private string EnglishField;

        /// <remarks/>
        [XmlElementAttribute("欄位1")]
        public int PostalCode
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
        [XmlElementAttribute("欄位2")]
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
        [XmlElementAttribute("欄位3")]
        public string English
        {
            get
            {
                return this.EnglishField;
            }
            set
            {
                this.EnglishField = value;
            }
        }
    }
}
