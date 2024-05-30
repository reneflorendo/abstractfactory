using DataParser.Business.AbstractFactories.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataParser.Business.AbstractFactories
{
    public class XmlReader : IDataReader
    {
        public IEnumerable<string> ReadData(string path)
        {
            throw new NotImplementedException();
        }
    }}
