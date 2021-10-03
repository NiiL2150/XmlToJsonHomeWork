using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XsonToJsonHomeWork.Readers
{
    public interface IReader
    {
        object Deserialize(Type type);
    }
}
