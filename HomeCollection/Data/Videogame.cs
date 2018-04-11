using HomeCollection.Interfaces;
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
    public class Videogame : IListViewPresentation
    {
        [Browsable(false)]
        public Guid Guid { get; set; } = Guid.NewGuid();

        [Category("Allgemein")]
        [DisplayName("Namen")]
        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
        public List<string> Titles { get; set; } = new List<string>();

        [Category("Allgemein")]
        [DisplayName("Beschreibung")]
        public string Description { get; set; } = string.Empty;
        
        // IListViewPresentation
        [Browsable(false)]
        [XmlIgnore]
        public string DisplayText { get { return ToString(); } }
        [Browsable(false)]
        [XmlIgnore]
        public Image DisplayImage { get { return null; } }
        [Browsable(false)]
        [XmlIgnore]
        public Guid ItemReference { get { return Guid; } }

        public Videogame()
        {
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (Titles.Count > 0 && Titles.First() != null)
                result.AppendLine(Titles.First());

            return result.ToString();
        }
    }
}
