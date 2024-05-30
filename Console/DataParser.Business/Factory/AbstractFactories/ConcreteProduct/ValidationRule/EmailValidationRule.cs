using System.Text.RegularExpressions;

namespace DataParser.Business.Factory.AbstractFactories.ConcreteProduct.ValidationRule
{
    public class EmailValidationRule : ICsvValidationRule
    {
        public EmailValidationRule()
        {
                
        }
        public bool ValidateLine(string[] values)
        {
            var email = values[3];//temporary solution of getting the email value
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            const string emailPattern = @"^(?!.*@)?([\w\.\-]+\@[a-zA-Z0-9\-]+\.[a-zA-Z]{2,})$";
            return Regex.IsMatch(email, emailPattern);
        }
    }
}
