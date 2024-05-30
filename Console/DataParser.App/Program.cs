using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataParser.Business.Enums;
using DataParser.Model;
using DataParser.Business.AbstractFactories;
using DataParser.Business.AbstractFactories.Interface;
using DataParser.Business.Factory.AbstractFactories.ConcreteProduct.ValidationRule;

namespace DataParser.App
{
    internal class Program
    {      

        static async Task Main(string[] args)
        {
            string filePath = @"C:\csv\employees.csv";

            try
            {
                DataFactory factory = new DataFactory();

                var csvFactory = factory.CreateDataFactory(DataParserType.Csv);
                char delimeter = ',';
                int fieldCount = 5;
                IDataReader reader = csvFactory.CreateDataReader();
                IDataValidator validator= csvFactory.CreateDataValidator(fieldCount);
                
                IDataParser parser = csvFactory.CreateDataParser();

                IEnumerable<string> rawData = await reader.ReadData(filePath);
          
                var passValition = validator.Validate(rawData, delimeter);
                
                if (passValition)
                {
                    IEnumerable<Person> persons = await parser.ParseData(rawData, delimeter);

                    foreach (var person in persons)
                    {
                        Console.WriteLine($"Name: {person.Firstname} {person.Lastname}, Age: {person.Age}, Email: {person.Email}");
                    }
                }
            }
            catch (Exception ex)
           {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
           }
            Console.ReadLine();
        }

    }
}
