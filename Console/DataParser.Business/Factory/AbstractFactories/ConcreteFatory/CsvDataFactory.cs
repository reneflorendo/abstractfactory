﻿using DataParser.Business.AbstractFactories.Interface;

namespace DataParser.Business.AbstractFactories
{
    public class CsvDataFactory : IDataFactory
    {
        public IDataParser CreateDataParser()
        {
            return new CsvParser();
        }
        public IDataReader CreateDataReader()
        {
            return new CsvReader();
        }
        public IDataValidator CreateDataValidator(int fieldCount)
        {
            return new CsvValidator(fieldCount);
        }
    }
}
