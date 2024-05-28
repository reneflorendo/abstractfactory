using DataParser.Business.AbstractFactories.Contracts;
using DataParser.Model;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser.Business.AbstractFactories
{
    public class CsvParser : IDataParser
    {
        public async Task<IEnumerable<Person>> ParseData(IEnumerable<string> lines)
        {
            if (!lines.Any())
            {
                throw new Exception("CSV file is empty.");
            }

            lines = lines.Skip(1);

            var personList = new ConcurrentBag<Person>();
            var parseTasks = lines.Select(line => Task.Run(() =>
            {
                var person = ParseLineToPerson(line);
                personList.Add(person);
            }));

            await Task.WhenAll(parseTasks);

            return personList;
        }

        public Person ParseLineToPerson(string line)
        {
            var values = line.Split(',');

            if (values.Length < 5)
            {
                throw new Exception("Invalid CSV format: Line has less than 5 fields.");
            }

            return new Person
            {
                Firstname = values[0],
                Lastname = values[1],
                Age = Convert.ToInt32(values[2]),
                Email = values[3],
                DateofBirth = Convert.ToDateTime(values[4])
            };
        }

    }
}
