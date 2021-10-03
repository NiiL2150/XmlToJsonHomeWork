using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlToJsonHomeWork
{
    public class XmlSaver : IXmlSaver
    {
        public void Serialize(object ob)
        {
            XmlSerializer serializer = new XmlSerializer(ob.GetType());
            using (FileStream fs = new FileStream("xmlSample.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, ob);
            }
        }
    }
}
