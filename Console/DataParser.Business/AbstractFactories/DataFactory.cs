using DataParser.Business.AbstractFactories.Contracts;
using DataParser.Business.Enums;
using DataParser.Business.AbstractFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser.Business.AbstractFactories
{
    public class DataFactory
    {
        public DataFactory()
        {

        }
        public IDataFactory CreateDataFactory(DataParserType dataParserType)
        {
            switch (dataParserType)
            {
                case DataParserType.Csv:
                    return new CsvDataFactory();               
                default:
                    throw new ArgumentException($"Unsupported data format: {dataParserType}");
            }
        }
    }
}
