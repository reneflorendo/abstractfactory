using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser.Business.AbstractFactories.Interface
{
     public interface IDataValidator
    {
        bool Validate(IEnumerable<string> rawData, char delimeter);
    }
}
