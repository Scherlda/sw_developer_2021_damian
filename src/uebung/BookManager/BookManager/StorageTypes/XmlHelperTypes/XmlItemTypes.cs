using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.StorageTypes.XmlHelperTypes
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class ItemListRoot
    {

        private Item[] itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public Item[] Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public  class Item
    {

        private string titelField;

        private string autorField;

        private string publisherField;

        private int ageRecommendationField;

        private string languageField;

        private int yearOfPublicationField;

        /// <remarks/>
        public string Titel
        {
            get
            {
                return this.titelField;
            }
            set
            {
                this.titelField = value;
            }
        }

        /// <remarks/>
        public string Autor
        {
            get
            {
                return this.autorField;
            }
            set
            {
                this.autorField = value;
            }
        }

        /// <remarks/>
        public string Publisher
        {
            get
            {
                return this.publisherField;
            }
            set
            {
                this.publisherField = value;
            }
        }

        /// <remarks/>
        public int AgeRecommendation
        {
            get
            {
                return this.ageRecommendationField;
            }
            set
            {
                this.ageRecommendationField = value;
            }
        }

        /// <remarks/>
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        public int YearOfPublication
        {
            get
            {
                return this.yearOfPublicationField;
            }
            set
            {
                this.yearOfPublicationField = value;
            }
        }
    }


}
