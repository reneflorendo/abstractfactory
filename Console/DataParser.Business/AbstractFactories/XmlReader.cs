using DataParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser.Business.AbstractFactories
{
    public class XmlReader : IDataReader
    {
        public Task<IEnumerable<string>> ReadData(string path)
        {
            throw new NotImplementedException();
        }
    }
}
