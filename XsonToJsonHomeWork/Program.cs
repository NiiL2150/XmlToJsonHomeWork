using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using XsonToJsonHomeWork.Readers;

namespace XmlToJsonHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass sample = new SampleClass();
            XmlSaver xmlSaver = new XmlSaver();
            sample.Save(xmlSaver);

            XmlToJsonAdapter adapter = new XmlToJsonAdapter();
            JsonSaver jsonSaver = new JsonSaver();
            XmlReader xmlReader = new XmlReader();

            adapter.Serialize(jsonSaver, xmlReader, sample.GetType());
        }
    }
}
