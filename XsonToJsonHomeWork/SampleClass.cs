using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlToJsonHomeWork
{
    [Serializable]
    public class SampleClass
    {
        public bool TmpBool { get; set; }
        public int TmpInt { get; set; }
        public string TmpString { get; set; }
        public SampleClass()
        {
            TmpBool = true;
            TmpInt = Int32.MaxValue;
            TmpString = "Lorem ipsum dolor sit amet jumps over the lazy dog";
        }
        public void Save(IXmlSaver serializer)
        {
            serializer.Serialize(this);
        }
    }
}
