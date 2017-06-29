using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RV.Services
{
    public class DetailPostalCodeService
    {

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute("dataroot", Namespace = "", IsNullable = false)]
        public partial class XML
        {

            private DetailPostalCode[] xml_10510Field;

            private System.DateTime generatedField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Xml_10510")]
            public DetailPostalCode[] detailPostalCodes
            {
                get
                {
                    return this.xml_10510Field;
                }
                set
                {
                    this.xml_10510Field = value;
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


    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class dataroot
    {

        private datarootItem1050429_行政區經緯度toPost[] item1050429_行政區經緯度toPostField;

        private System.DateTime generatedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("1050429_行政區經緯度(toPost)")]
        public datarootItem1050429_行政區經緯度toPost[] Item1050429_行政區經緯度toPost
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class datarootItem1050429_行政區經緯度toPost
    {

        private string 行政區名Field;

        private ushort item3碼郵遞區號Field;

        private decimal 中心點經度Field;

        private decimal 中心點緯度Field;

        private string tGOS_URLField;

        /// <remarks/>
        public string 行政區名
        {
            get
            {
                return this.行政區名Field;
            }
            set
            {
                this.行政區名Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("3碼郵遞區號")]
        public ushort Item3碼郵遞區號
        {
            get
            {
                return this.item3碼郵遞區號Field;
            }
            set
            {
                this.item3碼郵遞區號Field = value;
            }
        }

        /// <remarks/>
        public decimal 中心點經度
        {
            get
            {
                return this.中心點經度Field;
            }
            set
            {
                this.中心點經度Field = value;
            }
        }

        /// <remarks/>
        public decimal 中心點緯度
        {
            get
            {
                return this.中心點緯度Field;
            }
            set
            {
                this.中心點緯度Field = value;
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
