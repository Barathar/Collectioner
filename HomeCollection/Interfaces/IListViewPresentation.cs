using System;
using System.ComponentModel;
using System.Drawing;
using System.Xml.Serialization;

namespace HomeCollection.Interfaces
{
    public interface IListViewPresentation
    {
        string DisplayText { get; }
        Image DisplayImage { get; }        
        Guid ItemReference { get; }
    }
}
