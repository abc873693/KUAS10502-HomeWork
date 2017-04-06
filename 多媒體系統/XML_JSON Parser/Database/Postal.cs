using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML_JSON_Parser
{


    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("dataroot", Namespace = "", IsNullable = false)]
    public partial class Data
    {

        private County[] county_h_10508Field;

        private System.DateTime generatedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("county_h_10508")]
        public County[] Countrys
        {
            get
            {
                return this.county_h_10508Field;
            }
            set
            {
                this.county_h_10508Field = value;
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class County
    {

        private ushort PostalCodeField;

        private string SectionField;

        private string EnglishField;

        /// <remarks/>
        [XmlElementAttribute("欄位1")]
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
