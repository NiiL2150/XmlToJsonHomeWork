using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XsonToJsonHomeWork.Readers
{
    public class XmlReader : IXmlReader
    {
        public object Deserialize(Type type)
        {
            XmlSerializer formatter = new XmlSerializer(type);
            using (FileStream fs = new FileStream("xmlSample.xml", FileMode.OpenOrCreate))
            {
                return formatter.Deserialize(fs);
            }
        }
    }
}
