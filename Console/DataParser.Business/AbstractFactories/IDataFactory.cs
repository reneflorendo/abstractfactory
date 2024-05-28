using DataParser.Business.AbstractFactories.Contracts;
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
    }
}
