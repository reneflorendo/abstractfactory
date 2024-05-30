using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser.Business.Factory.AbstractFactories.ConcreteProduct.ValidationRule
{
    public class EmailValidationRule : ICsvValidationRule
    {
        public EmailValidationRule()
        {
                
        }
        public bool ValidateLine(string[] values)
        {
            return true;
        }
    }
}
