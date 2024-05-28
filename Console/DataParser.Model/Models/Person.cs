using DataParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParser.Model
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public DateTime DateofBirth { get; set; }
                
    }
}
