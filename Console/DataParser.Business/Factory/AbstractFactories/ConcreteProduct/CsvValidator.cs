using DataParser.Business.AbstractFactories.Interface;
using DataParser.Business.Factory.AbstractFactories.ConcreteProduct.ValidationRule;
using System.Collections.Generic;
using System.Linq;

namespace DataParser.Business.AbstractFactories
{
    public class CsvValidator : IDataValidator
    {
        private readonly List<ICsvValidationRule> _validationRules;
        public CsvValidator(int fieldCount)
        {
            _validationRules=new List<ICsvValidationRule>() {
              new FieldCountValidationRule(fieldCount),
              new EmailValidationRule()
            };                
        }
        public bool Validate(IEnumerable<string> rawData, char delimeter)
        {
            if (rawData.Any())
            {
               rawData= rawData.Skip(1);

                foreach (string rawDataItem in rawData)
                {
                    var values = rawDataItem.Split(delimeter);
                    foreach (var item in _validationRules)
                    {   
                        if (!item.ValidateLine(values))
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            return false;
        }
    }
}
