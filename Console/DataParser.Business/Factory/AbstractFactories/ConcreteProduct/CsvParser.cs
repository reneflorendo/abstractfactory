using DataParser.Business.AbstractFactories.Interface;
using DataParser.Model;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DataParser.Business.AbstractFactories
{
    public class CsvParser : IDataParser
    {
        public IEnumerable<Person> ParseData(IEnumerable<string> lines, char delimiter)
        {
            lines = lines.Skip(1); // Assuming header row

            var personList = new List<Person>();

            foreach (var line in lines)
            {
                var person = ParseLineToPerson(line, delimiter);
                personList.Add(person);
            }

            return personList;
        }

        public Person ParseLineToPerson(string line, char delimeter)
        {
            var values = line.Split(delimeter);

            return new Person
            {
                Firstname = values[0],
                Lastname = values[1],
                Email = values[3],
                DateofBirth = Convert.ToDateTime(values[4])
            };
        }

    }
}
