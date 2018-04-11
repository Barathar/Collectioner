using System;
using System.ComponentModel;

namespace HomeCollection.Data
{
    [Serializable]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Range
    {
        [DisplayName("Minimal")]
        public int Minimal { get; set; }
        [DisplayName("Maximal")]
        public int Maximal { get; set; }

        public Range()
        {
        }

        public override string ToString()
        {
            return string.Format($"{Minimal} - {Maximal}");
        }
    }
}
