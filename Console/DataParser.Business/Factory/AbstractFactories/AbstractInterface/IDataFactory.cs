using DataParser.Business.AbstractFactories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser.Business.AbstractFactories
{
    public interface IDataFactory
    {
        IDataReader CreateDataReader();
        IDataParser CreateDataParser();
        IDataValidator CreateDataValidator(int fieldCount);
    }
}
