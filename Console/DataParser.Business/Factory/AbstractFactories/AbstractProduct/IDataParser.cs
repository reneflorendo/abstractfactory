using DataParser.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataParser.Business.AbstractFactories.Interface
{
    public interface IDataParser
    {
        IEnumerable<Person> ParseData(IEnumerable<string> rawData, char delimeter);
    }
}
