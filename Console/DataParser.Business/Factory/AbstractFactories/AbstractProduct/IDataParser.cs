using DataParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser.Business.AbstractFactories.Interface
{
    public interface IDataParser
    {
        Task<IEnumerable<Person>> ParseData(IEnumerable<string> rawData, char delimeter);

    }
}
