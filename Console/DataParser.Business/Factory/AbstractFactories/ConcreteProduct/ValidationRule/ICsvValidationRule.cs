namespace DataParser.Business.Factory.AbstractFactories.ConcreteProduct.ValidationRule
{
    public interface ICsvValidationRule
    {
        bool ValidateLine(string[] values);
    }
}
