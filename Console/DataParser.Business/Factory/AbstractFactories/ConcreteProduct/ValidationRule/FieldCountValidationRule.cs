namespace DataParser.Business.Factory.AbstractFactories.ConcreteProduct.ValidationRule
{
    public class FieldCountValidationRule : ICsvValidationRule
    {
        private readonly int _expectecFields;
        public FieldCountValidationRule(int expectedFields)
        {
            _expectecFields = expectedFields;           
        }
        public bool ValidateLine(string[] values)
        {
            return values.Length == _expectecFields;
          
        }
    }
}
