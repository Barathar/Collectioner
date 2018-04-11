using HomeCollection.Interfaces;
using HomeCollection.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace HomeCollection.Data
{
    [Serializable]
    public class Boardgame : IListViewPresentation
    {
        private Image image;
        private string imageBase64;

        [Browsable(false)]
        public Guid Guid { get; set; } = Guid.NewGuid();

        [Category("Allgemein")]
        [DisplayName("Namen")]
        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
        public List<string> Titles { get; set; } = new List<string>();

        [Browsable(false)]
        [XmlIgnore]
        public string Title
        {
            get
            {
                if (Titles.Count > 0 && Titles.First() != null)
                    return Titles.First();

                return string.Empty;
            }
        }

        [Category("Allgemein")]
        [DisplayName("Beschreibung")]
        public string Description { get; set; } = string.Empty;

        [Category("Allgemein")]
        [DisplayName("Erscheinungsjahr")]
        public int YearPublished { get; set; } = 2000;

        [Category("Allgemein")]
        [DisplayName("Tags")]
        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
        public List<string> Tags { get; set; } = new List<string>();

        [Category("Allgemein")]
        [DisplayName("Alter")]
        public int Age { get; set; } = 0;

        [Category("Allgemein")]
        [DisplayName("Spieleranzahl")]
        public Range Players { get; set; }

        [Category("Allgemein")]
        [DisplayName("Spielzeit")]
        public Range Playtime { get; set; }

        [XmlIgnore]
        [Category("Bilder")]
        [DisplayName("Bild")]
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                imageBase64 = Base64Converter.ImageToString(value);
            }
        }

        [Browsable(false)]
        public string ImageBase64
        {
            get
            {
                return imageBase64;
            }
            set
            {
                image = Base64Converter.StringToImage(value);
                imageBase64 = value;
            }
        }

        [XmlIgnore]
        [Category("Bilder")]
        [DisplayName("Vorschaubild")]
        public Image PreviewImage { get; set; }

        //[Category("Bilder")]
        //[DisplayName("Weitere Bilder")]
        //public List<Image> AdditionalImages { get; set; }

        [Category("Ersteller")]
        [DisplayName("Verlage")]
        public List<string> Publisher { get; set; }

        [Category("Ersteller")]
        [DisplayName("Künstler")]
        public List<string> Artists { get; set; }

        [Category("Ersteller")]
        [DisplayName("Entwickler")]
        public List<string> Designer { get; set; }

        [Category("Meta")]
        [DisplayName("Anzahl")]
        public int Amount { get; set; }

        [Category("Meta")]
        [DisplayName("Gespielt?")]
        public bool Played { get; set; }

        [Category("Meta")]
        [DisplayName("Bewertung")]
        public int Ranking { get; set; }

        [Category("Meta")]
        [DisplayName("Regeln")]
        public List<string> Rules { get; set; }

        [Category("Meta")]
        [DisplayName("Weiteres")]
        public List<string> Additional { get; set; }

        [Category("Meta")]
        [DisplayName("Erweiterungen")]
        public List<Guid> Expansions { get; set; }


        // IListViewPresentation
        [Browsable(false)]
        [XmlIgnore]
        public string DisplayText { get { return ToString(); } }
        [Browsable(false)]
        [XmlIgnore]
        public Image DisplayImage { get { return Image; } }
        [Browsable(false)]
        [XmlIgnore]
        public Guid ItemReference { get { return Guid; } }

        public Boardgame()
        {
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(Title))
                result.AppendLine(Title);

            if (YearPublished > 0)
                result.AppendLine($"({YearPublished})");

            return result.ToString();
        }
    }
}
