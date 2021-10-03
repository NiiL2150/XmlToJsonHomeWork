using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XsonToJsonHomeWork.Readers;

namespace XmlToJsonHomeWork
{
    public class XmlToJsonAdapter
    {
        public void Serialize(ISaver saver, IReader reader, Type type)
        {
            saver.Serialize(reader.Deserialize(type));
        }
    }
}
