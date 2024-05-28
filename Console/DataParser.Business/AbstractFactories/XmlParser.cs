using DataParser.Business.AbstractFactories.Contracts;
using DataParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser.Business.AbstractFactories
{
    public class XmlParser : IDataParser
    {
        public Task<IEnumerable<Person>> ParseData(IEnumerable<string> rawData)
        {
            throw new NotImplementedException();
        }
    }
}
