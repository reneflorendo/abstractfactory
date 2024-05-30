using DataParser.Business.AbstractFactories.Interface;
using DataParser.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataParser.Business.AbstractFactories
{
    public class XmlParser : IDataParser
    {
        public IEnumerable<Person> ParseData(IEnumerable<string> rawData, char delimeter)
        {
            throw new NotImplementedException();
        }
    }
}
