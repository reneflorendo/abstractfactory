﻿using DataParser.Business.AbstractFactories.Interface;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DataParser.Business.AbstractFactories
{
    public class CsvReader : IDataReader
    {
        public async Task<IEnumerable<string>> ReadData(string path)
        {
            var lines = new List<string>();
            using (var reader = new StreamReader(path))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines;
        }
    }
}