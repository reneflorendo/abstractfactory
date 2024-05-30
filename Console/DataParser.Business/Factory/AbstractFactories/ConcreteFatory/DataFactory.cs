using DataParser.Business.AbstractFactories.Interface;
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
        private readonly Dictionary<DataParserType, IDataFactory> _factoryMap;
        public DataFactory()
        {
            _factoryMap = new Dictionary<DataParserType, IDataFactory>
            {
                { DataParserType.Csv, new CsvDataFactory() }
            };
        }
        public IDataFactory CreateDataFactory(DataParserType dataParserType)
        {
            if (_factoryMap.TryGetValue(dataParserType, out var factory))
            {
                return factory;
            }

            throw new ArgumentException("Unsupported employee type");

        }
    }
}
