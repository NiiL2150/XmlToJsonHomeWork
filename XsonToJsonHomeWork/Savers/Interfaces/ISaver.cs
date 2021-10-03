using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlToJsonHomeWork
{
    public interface ISaver
    {
        void Serialize(object ob);
    }
}
