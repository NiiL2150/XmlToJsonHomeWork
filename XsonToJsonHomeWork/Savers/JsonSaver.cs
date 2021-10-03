using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace XmlToJsonHomeWork
{
    public class JsonSaver : IJsonSaver
    {
        public async void Serialize(object ob)
        {
            using (FileStream fs = new FileStream("jsonSample.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync(fs, ob, ob.GetType());
            }
        }
    }
}
