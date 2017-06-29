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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class DetailPostalCode
    {

        private uint postal_codeField;

        private string cityField;

        private string roadField;

        private string blockField;

        [XmlElementAttribute("欄位1")]
        /// <remarks/>
        public uint Postal_code
        {
            get
            {
                return this.postal_codeField;
            }
            set
            {
                this.postal_codeField = value;
            }
        }
        [XmlElementAttribute("欄位4")]
        /// <remarks/>
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
        [XmlElementAttribute("欄位2")]
        /// <remarks/>
        public string road
        {
            get
            {
                return this.roadField;
            }
            set
            {
                this.roadField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("欄位3")]
        public string block
        {
            get
            {
                return this.blockField;
            }
            set
            {
                this.blockField = value;
            }
        }


    }
}
