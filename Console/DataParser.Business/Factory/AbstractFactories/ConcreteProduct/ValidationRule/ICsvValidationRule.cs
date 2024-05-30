using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser.Business.Factory.AbstractFactories.ConcreteProduct.ValidationRule
{
    public interface ICsvValidationRule
    {
        bool ValidateLine(string[] values);
    }
}
