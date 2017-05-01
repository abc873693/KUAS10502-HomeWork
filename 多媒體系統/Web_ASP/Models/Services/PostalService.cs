using RV.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Service
{
    public class PostalService
    {
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute("dataroot", Namespace = "", IsNullable = false)]
        public partial class XML
        {

            private Postal[] county_h_10508Field;

            private System.DateTime generatedField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("county_h_10508")]
            public Postal[] Countrys
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
    }
    
}
