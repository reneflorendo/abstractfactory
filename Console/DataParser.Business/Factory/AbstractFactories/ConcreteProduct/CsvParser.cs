using DataParser.Business.AbstractFactories.Interface;
using DataParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataParser.Business.AbstractFactories
{
    public class CsvParser : IDataParser
    {
        public async Task<IEnumerable<Person>> ParseData(IEnumerable<string> lines, char delimeter)
        {         
            lines = lines.Skip(1);

            var personList = new List<Person>();
            var parseTasks = lines.Select(line => Task.Run(() =>
            {
                var person = ParseLineToPerson(line, delimeter);
                personList.Add(person);
            }));

            await Task.WhenAll(parseTasks);

            return personList;
        }

        public Person ParseLineToPerson(string line, char delimeter)
        {
            var values = line.Split(delimeter);

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
