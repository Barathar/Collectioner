using HomeCollection.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HomeCollection.Utility
{
    public class XmlDatabase
    {
        private readonly string name;
        private readonly XmlSerializer serializer;

        public XmlDatabase(string databaseName, Type storedType)
        {
            name = databaseName;
            serializer = new XmlSerializer(storedType);
        }

        public void Save(object collection)
        {
            string xml = Serialize(collection);
            XDocument document = XDocument.Parse(xml);

            string filename = GetFilename();
            document.Save(filename);
        }
        public object Load()
        {
            return Deserialize();
        }

        private string Serialize(object collection)
        {
            string result = string.Empty;

            using (var stringWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter))
                {
                    serializer.Serialize(xmlWriter, collection);
                    result = stringWriter.ToString();
                }
            }

            return result;
        }
        private object Deserialize()
        {
            string filename = GetFilename();
            if (!File.Exists(filename))
                return null;

            FileStream fileStream = new FileStream(filename, FileMode.Open);
            XmlReader reader = XmlReader.Create(fileStream);

            object result = serializer.Deserialize(reader);
            fileStream.Close();

            return result;
        }

        private string GetFilename()
        {
            return name + ".xml";
        }
    }
}
