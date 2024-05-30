using DataParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser.Business.AbstractFactories.Interface
{
    public interface IDataReader
    {
        Task<IEnumerable<string>> ReadData(string path);
    }
}
